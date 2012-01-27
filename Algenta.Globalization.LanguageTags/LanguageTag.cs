using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Algenta.Globalization.LanguageTags
{
    public class LanguageTag
    {
        private string languageTag;

        public bool IsPrivateUse { get; private set; }
        public bool IsGrandfathered { get; private set; }

        private string language;
        private string extlang;
        private string script;
        private string region;
        private Collection<string> variants;
        private Dictionary<char,string> extensions;
        private string privateUse;

    }
}
