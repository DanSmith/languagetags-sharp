using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Algenta.Globalization.LanguageTags
{
    /// <summary>
    /// Tag Registry
    /// </summary>
    /// <remarks></remarks>
    public static partial class TagRegistry
    {

        public static bool ValidateTag(string textTag)
        {
            LanguageTag tag = null;
            bool result = TryParse(textTag, out tag);
            return result;
        }


        public static bool TryParse(string textTag, out LanguageTag tag)
        {
            CheckNullOrEmpty(textTag, "languageTag");
            textTag = textTag.ToLowerInvariant();
            
            /*
            string language = null;
            string extlang;
            string script = null;
            string region = null;
            Collection<string> variants = null;
            Dictionary<char, string> extensions = null;
            string privateUse = null;*/
            tag = new LanguageTag();

            if (IsPrivateUse(textTag)) 
            {
                tag.IsPrivateUse = true;
                return true; 
            }

            if (Array.BinarySearch<string>(Grandfathered, textTag) >= 0)
            {
                tag.IsGrandfathered = true;
                return true;

            }


            char[] separator = new char[] {'-'};
            string[] parts = textTag.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            
            ParseState state = ParseState.None;
                        
            if (parts.Length == 0) { return false; }

            #region Language
            string nextPart = parts[0];
            if (nextPart.Length < 2 || nextPart.Length > 8 || !IsUsAsciiLetters(nextPart)) // 2*3ALPHA / 4ALPHA / 5*8ALPHA
            { 
                // "Invalid language format."
                return false;
            }
            if (Array.BinarySearch<string>(Languages, nextPart) < 0)
            { 
                // "Invalid language."
                return false;            
            }
            tag.Language = nextPart;
            state = ParseState.Language;
            #endregion

            for (int i = 1; i < parts.Length; ++i)
            {
                nextPart = parts[i];

                if (nextPart.Length == 3 && IsUsAsciiLetters(nextPart)) // 3ALPHA   not used yet-> *2("-" 3ALPHA)
                {
                    if (state != ParseState.Language)
                    {
                        // "Invalid extended language location, must follow language."
                        return false;
                    }

                    if (Array.BinarySearch<string>(ExtLangs, nextPart) < 0)
                    {
                        // "Invalid ext Language, see selected ISO 639 codes"
                        return false;
                    }
                    tag.Extlang = nextPart;
                    state = ParseState.ExtLang;                    
                    continue;
                }

                if (nextPart.Length == 4 && IsUsAsciiLetters(nextPart)) // 4ALPHA
                {
                    if (state >= ParseState.Script)
                    {
                        // "Invalid extended language location, must come before " +state.ToString();
                        return false;
                    }

                    if (Array.BinarySearch<string>(Scripts, nextPart) < 0)
                    {
                        // "Invalid Script, see ISO 15924 codes."
                        return false;
                    }
                    tag.Script = nextPart;
                    state = ParseState.Script;
                    continue;
                }

                if ((nextPart.Length == 2 && IsUsAsciiLetters(nextPart)) ||       // 2ALPHA
                    (nextPart.Length == 3 && nextPart.All(c => char.IsDigit(c)))) // 3DIGIT
                {
                    if (state >= ParseState.Region)
                    {
                        // "Invalid Region location, must come before " +state.ToString();
                        return false;
                    }

                    if (Array.BinarySearch<string>(Regions, nextPart) < 0)
                    {
                        // "Invalid Region, see ISO 3166-1 codes and UN M.49 codes
                        return false;
                    }
                    tag.Region = nextPart;
                    state = ParseState.Region;
                    continue;
                }

                if ((nextPart.Length >= 5 && nextPart.Length <= 8 && IsUsAsciiLettersOrDigits(nextPart)) ||               // 5*8alphanum
                    (nextPart.Length == 4 && char.IsDigit(nextPart[0]) && IsUsAsciiLettersOrDigits(nextPart.Substring(1, 3)))) //DIGIT 3alphanum
                {
                    if (state > ParseState.Variant)
                    {
                        // "Invalid Variant location, must come before " +state.ToString();
                        return false;
                    }

                    if (Array.BinarySearch<string>(Variants, nextPart) < 0)
                    {
                        // "Invalid Variant"
                        return false;
                    }
                    //if (variants == null) { variants = new Collection<string>(); }
                    if (tag.Variants.Contains(nextPart))
                    {
                        // "Repeated Variant"
                        return false;
                    }
                    tag.Variants.Add(nextPart);
                    state = ParseState.Variant;
                    continue;
                }

                if (nextPart.Length == 1 &&
                    nextPart[0] != 'x' && nextPart[0] != 'X' &&
                    (char.IsDigit(nextPart[0]) || IsUsAsciiLetters(nextPart[0])) ) // A-W Y-Z a-w y-z 0-9
                {
                    if (state > ParseState.Extension)
                    {
                        // "Invalid Extension location, must come before " +state.ToString();
                        return false;
                    }

                    char singleton = nextPart[0];
                    string extValue = null;

                    i++;
                    if (i >= parts.Length)
                    {
                        // "Extension value not present."
                        return false;
                    }
                    nextPart = parts[i];

                    if (nextPart.Length < 2 || nextPart.Length > 8 || !IsUsAsciiLettersOrDigits(nextPart)) 
                    {
                        // "Invalid Extension value format."
                        return false;
                    }
                    extValue = nextPart;
                    while (i + 1 < parts.Length)
                    {
                        i++;
                        nextPart = parts[i];
                        if (nextPart.Length < 2 || nextPart.Length > 8 || !IsUsAsciiLettersOrDigits(nextPart))
                        {
                            i--;
                            nextPart = parts[i];
                            break;
                        }
                        extValue = extValue + "-" + nextPart;
                    }

                    //if (extensions == null) { extensions = new Dictionary<char, string>(); }
                    if (tag.Extensions.ContainsKey(singleton))
                    {
                        // "Repeated Extension"
                        return false;
                    }
                    tag.Extensions.Add(singleton, extValue);
                    state = ParseState.Extension;
                    continue;
                }

                if (nextPart.Length == 1 && (nextPart[0] == 'x' || nextPart[0] == 'X' )) // x x
                {
                    if (state >= ParseState.PrivateUse)
                    {
                        // "Private Use location must be used only once.";
                        return false;
                    }

                    i++;
                    if (i >= parts.Length)
                    {
                        // "Private Use value not present."
                        return false;
                    }
                    nextPart = parts[i];
                    

                    if (nextPart.Length < 1 || nextPart.Length > 8 || !IsUsAsciiLettersOrDigits(nextPart)) 
                    {
                        // "Invalid Private Use value format."
                        return false;
                    }

                    string privateValue = nextPart;
                    while (i + 1 < parts.Length)
                    {
                        i++;
                        nextPart = parts[i];
                        if (nextPart.Length < 1 || nextPart.Length > 8 || !IsUsAsciiLettersOrDigits(nextPart))
                        {
                            i--;
                            nextPart = parts[i];
                            break;
                        }
                        privateValue = privateValue + "-" + nextPart;
                    }

                    tag.PrivateUse = privateValue;
                    state = ParseState.PrivateUse;
                    continue;
                }

                // Could not match Subtag to specific section
                return false;
            }
               


            return true;
        }


        private enum ParseState
        {
            None = 0,
            Language = 1,
            ExtLang = 2,
            Script = 3,
            Region = 4,
            Variant = 5,
            Extension = 6,
            PrivateUse =7
        }

        #region Faster Than Regex
        public static bool IsUsAsciiLetters(string s)
        {
            for (int i = 0; i < s.Length; ++i)
            {
                if (IsUsAsciiLetters(s[i]))
                {
                    continue;
                }
                return false;
            }
            return true;
        }
        public static bool IsUsAsciiLettersOrDigits(string s)
        {
            for (int i = 0; i < s.Length; ++i)
            {
                if (IsUsAsciiLetters(s[i]) || char.IsDigit(s[i]))
                {
                    continue;
                }
                return false;
            }
            return true;
        }
        public static bool IsUsAsciiLetters(char c)
        {            
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                return true;
            }
            return false;
        }
        #endregion

        /// <summary>
        /// Conforms to "x" 1*("-" (1*8alphanum))
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static bool IsPrivateUse(string s)
        {
            if (s.Length < 3) { return false; }
            if (s.Length > 10) { return false; }
            if (s[0] != 'x') { return false; }
            if (s[1] != '-') { return false; }
            
            for (int i = 2; i < s.Length; ++i)
            {
                if (!Char.IsLetterOrDigit(s, i))
                {
                    return false;
                }
            }
            return true;
        }

        private static void CheckNullOrEmpty(string value, string parameterName)
        {
            if (value == null)
                throw new ArgumentNullException(parameterName);

            if (value.Length == 0)
                throw new ArgumentException("Argument Empty", parameterName);
        }
    }
}
