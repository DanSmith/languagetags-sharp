using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algenta.Globalization.LanguageTags
{
    public class ValidationResult
    {
        public string ErrorMessage { get; set; }
        public bool Valid { get; set; }
        public LanguageTag ValidTag { get; set; }
    }
}
