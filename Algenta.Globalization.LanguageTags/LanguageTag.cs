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

        public string Value
        {
            get { return string.Empty; } //TODO
        }

        public bool IsPrivateUse { get; internal set; }
        public bool IsGrandfathered { get; internal set; }

        public string Language { get; internal set; }
        public string Extlang { get; internal set; }
        public string Script { get; internal set; }
        public string Region { get; internal set; }
        
        private Collection<string> variants = new Collection<string>();
        public Collection<string> Variants { get { return variants; } }
        
        private Dictionary<char, string> extensions = new Dictionary<char, string>();
        public Dictionary<char, string> Extensions { get { return extensions; } }
        
        public string PrivateUse { get; internal set; }

    }
}
