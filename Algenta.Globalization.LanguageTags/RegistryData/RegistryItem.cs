using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;

namespace Algenta.Globalization.LanguageTags
{
    public class RegistryItem
    {
        public string Subtag { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? Deprecated { get; set; }

        private Collection<string> descriptions = new Collection<string>();
        public Collection<string> Descriptions { get { return descriptions; } }
        public string Comments { get; set; }

        public string SuppressScript { get; set; }
        public string Scope { get; set; }
        public string Macrolanguage { get; set; }
        public string PreferredValue { get; set; }
        public string Prefix { get; set; }

        public bool IsExpanded { get; set; }
    }
}
