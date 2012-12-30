using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algenta.Globalization.LanguageTags;

namespace Algenta.Globalization.LanguageTags.Test
{
    [TestClass]
    public class UnitTest
    {

        // Ignore case on round trip through parser/canonicalization
        private bool ignoreCase = true;


        [TestMethod]
        public void TestPrivateUseValidation()
        {
            LanguageTag result = null;
            Assert.IsTrue(TagRegistry.TryParse("x-a", out result));
            Assert.AreEqual("x-a", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("x-aaaaaaaa", out result));
            Assert.AreEqual("x-aaaaaaaa", result.Value, ignoreCase);

            Assert.IsFalse(TagRegistry.ValidateTag("x-aaaaaaaaa"));
            Assert.IsFalse(TagRegistry.ValidateTag("xaaaaaaaa"));
        }

        [TestMethod]
        public void TestGrandfatheredValidation()
        {
            LanguageTag result = null;
            Assert.IsTrue(TagRegistry.TryParse("zh-xiang", out result));
            Assert.AreEqual("zh-xiang", result.Value, ignoreCase);
        }


        [TestMethod]
        public void TestGetLanguage()
        {
            Language lang = TagRegistry.GetLanguage("en");

            Assert.IsTrue(lang.Descriptions.Contains("English"));
        }

        [TestMethod]
        public void TestGetRegion()
        {
            Region r = TagRegistry.GetRegion("US");

            Assert.IsTrue(r.Descriptions.Contains("United States"));
        }


        [TestMethod]
        public void TestLanguageValidation()
        {
            LanguageTag result = null;
            Assert.IsTrue(TagRegistry.TryParse("de", out result));//German
            Assert.AreEqual("de", result.Value, ignoreCase);

            Assert.IsTrue(TagRegistry.TryParse("fr", out result));//French
            Assert.AreEqual("fr", result.Value, ignoreCase);

            Assert.IsTrue(TagRegistry.TryParse("ja", out result));//Japanese
            Assert.AreEqual("ja", result.Value, ignoreCase);

            Assert.IsTrue(TagRegistry.TryParse("i-enochian", out result));//example of a grandfathered tag
            Assert.AreEqual("i-enochian", result.Value, ignoreCase);
        }

        [TestMethod]
        public void TestLanguageScriptValidation()
        {
            LanguageTag result = null;

            Assert.IsTrue(TagRegistry.TryParse("zh-Hant", out result));//Chinese written using the Traditional Chinese script
            Assert.AreEqual("zh-Hant", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("zh-Hans", out result));//Chinese written using the Simplified Chinese script
            Assert.AreEqual("zh-Hans", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("sr-Cyrl", out result));//Serbian written using the Cyrillic script
            Assert.AreEqual("sr-Cyrl", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("sr-Latn", out result));//Serbian written using the Latin script
            Assert.AreEqual("sr-Latn", result.Value, ignoreCase);
        }

        [TestMethod]
        public void TestExtendedLanguageSubtagsValidation()
        {
            LanguageTag result = null;

            Assert.IsTrue(TagRegistry.TryParse("zh-cmn-Hans-CN", out result)); //Chinese, Mandarin, Simplified script, as used in China
            Assert.AreEqual("zh-cmn-Hans-CN", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("cmn-Hans-CN", out result)); //Mandarin Chinese, Simplified script, as used in China
            Assert.AreEqual("cmn-Hans-CN", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("zh-yue-HK", out result)); //Chinese, Cantonese, as used in Hong Kong SAR
            Assert.AreEqual("zh-yue-HK", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("yue-HK", out result)); //Cantonese Chinese, as used in Hong Kong SAR
            Assert.AreEqual("yue-HK", result.Value, ignoreCase);
        }

        [TestMethod]
        public void TestLanguageScriptRegionValidation()
        {
            LanguageTag result = null;

            Assert.IsTrue(TagRegistry.TryParse("zh-Hans-CN", out result)); //Chinese written using the Simplified script as used in mainland China
            Assert.AreEqual("zh-Hans-CN", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("sr-Latn-RS", out result)); //Serbian written using the Latin script as used in Serbia
            Assert.AreEqual("sr-Latn-RS", result.Value, ignoreCase);
        }

        [TestMethod]
        public void TestLanguageVariantValidation()
        {
            LanguageTag result = null;

            Assert.IsTrue(TagRegistry.TryParse("sl-rozaj", out result)); //Resian dialect of Slovenian
            Assert.AreEqual("sl-rozaj", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("sl-rozaj-biske", out result)); //San Giorgio dialect of Resian dialect of Slovenian
            Assert.AreEqual("sl-rozaj-biske", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("sl-nedis", out result)); //Nadiza dialect of Slovenian
            Assert.AreEqual("sl-nedis", result.Value, ignoreCase);
        }

        [TestMethod]
        public void TestLanguageRegionVariantValidation()
        {
            LanguageTag result = null;

            Assert.IsTrue(TagRegistry.TryParse("de-CH-1901", out result)); //German as used in Switzerland using the 1901 variant [orthography]
            Assert.AreEqual("de-CH-1901", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("sl-IT-nedis", out result)); //Slovenian as used in Italy, Nadiza dialect
            Assert.AreEqual("sl-IT-nedis", result.Value, ignoreCase);
        }

        [TestMethod]
        public void TestLanguageScriptRegionVariantValidation()
        {
            LanguageTag result = null;

            Assert.IsTrue(TagRegistry.TryParse("hy-Latn-IT-arevela", out result)); //Eastern Armenian written in Latin script, as used in Italy
            Assert.AreEqual("hy-Latn-IT-arevela", result.Value, ignoreCase);
        }

        [TestMethod]
        public void TestLanguageRegionValidation()
        {
            LanguageTag result = null;

            Assert.IsTrue(TagRegistry.TryParse("de-DE", out result)); //German for Germany
            Assert.AreEqual("de-DE", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("en-US", out result)); //English as used in the United States
            Assert.AreEqual("en-US", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("es-419", out result));//Spanish appropriate for the Latin America 
                                                          //  and Caribbean region using the UN region code
            Assert.AreEqual("es-419", result.Value, ignoreCase);
        }

        [TestMethod]
        public void TestPrivateUseSubtagValidation()
        {
            LanguageTag result = null;

            Assert.IsTrue(TagRegistry.TryParse("de-CH-x-phonebk", out result));
            Assert.AreEqual("de-CH-x-phonebk", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("az-Arab-x-AZE-derbend", out result));
            Assert.AreEqual("az-Arab-x-AZE-derbend", result.Value, ignoreCase);
        }

        [TestMethod]
        public void TestPrivateUseTagRegistryValuesValidation()
        {
            LanguageTag result = null;

            Assert.IsTrue(TagRegistry.TryParse("x-whatever", out result)); //private use using the singleton 'x'
            Assert.AreEqual("x-whatever", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("qaa-Qaaa-QM-x-southern", out result)); //all private tags
            Assert.AreEqual("qaa-Qaaa-QM-x-southern", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("de-Qaaa", out result)); //German, with a private script
            Assert.AreEqual("de-Qaaa", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("sr-Latn-QM", out result)); //Serbian, Latin script, private region
            Assert.AreEqual("sr-Latn-QM", result.Value, ignoreCase);
            Assert.IsTrue(TagRegistry.TryParse("sr-Qaaa-RS", out result)); //Serbian, private script, for Serbia
            Assert.AreEqual("sr-Qaaa-RS", result.Value, ignoreCase);
        }

        [TestMethod]
        public void TestInvalidValidation()
        {
            

            Assert.IsFalse(TagRegistry.ValidateTag("de-419-DE")); //two region tags
            Assert.IsFalse(TagRegistry.ValidateTag("a-DE")); //(use of a single-character subtag in primary position; note
                                                          //that there are a few grandfathered tags that start with "i-" that are valid
            Assert.IsFalse(TagRegistry.ValidateTag("ar-a-aaa-b-bbb-a-ccc")); //two extensions with same single-letter prefix
        }
    }

}
