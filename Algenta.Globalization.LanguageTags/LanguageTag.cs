using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Algenta.Globalization.LanguageTags
{
    public class LanguageTag
    {
        internal LanguageTag() { }

        private string value;
        public string Value
        {
            get 
            {
                if (value != null) { return value; }
                StringBuilder result = new StringBuilder();

                if (IsPrivateUse)
                {
                    result.Append(PrivateUse); // this.PrivateUse contains leading x-
                    value = result.ToString();
                    return value;
                }
                else if (IsGrandfathered)//Redundant, but this reflects the logic
                {
                    result.Append(Grandfathered);
                    value = result.ToString();
                    return value;
                }
                

                result.Append(Language);
                if (Extlang != null)
                {
                    result.Append("-");
                    result.Append(Extlang);
                }

                if (Script != null)
                {
                    result.Append("-");
                    result.Append(Script);
                }

                if (Region != null)
                {
                    result.Append("-");
                    result.Append(Region);
                }

                foreach (string variant in Variants)
                {
                    result.Append("-");
                    result.Append(variant);
                }

                foreach (var extension in Extensions.OrderBy(x => x.Key))
                {
                    result.Append("-");

                    result.Append(extension.Key);
                    result.Append("-");
                    result.Append(extension.Value);
                }

                if (PrivateUse != null)
                {
                    result.Append("-x-");
                    result.Append(PrivateUse);
                }
                
                value = result.ToString();
                return value;
            } 
        }

        public bool IsPrivateUse { get; internal set; }
        public bool IsGrandfathered { get; internal set; }

        public string Language { get; internal set; }
        public string Extlang { get; internal set; }
        public string Script { get; internal set; }
        public string Region { get; internal set; }
        
        private Collection<string> variants;
        public Collection<string> Variants 
        { 
            get 
            {
                if (variants == null)
                {
                    variants = new Collection<string>();
                }
                return variants;
            } 
        
        }
        
        private Dictionary<char, string> extensions;
        public Dictionary<char, string> Extensions 
        { 
            get 
            {
                if (extensions == null)
                {
                    extensions = new Dictionary<char, string>();
                }
                return extensions; 
            } 
        }
        
        public string PrivateUse { get; internal set; }
        public string Grandfathered { get; internal set; }
        

    }
}
