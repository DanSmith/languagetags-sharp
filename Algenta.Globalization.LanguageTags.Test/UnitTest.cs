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
        [TestMethod]
        public void TestPrivateUseValidation()
        {
            

            Assert.IsTrue(TagRegistry.ValidateTag("x-a"));
            Assert.IsTrue(TagRegistry.ValidateTag("x-aaaaaaaa"));
            Assert.IsTrue(TagRegistry.ValidateTag("x-a"));
            Assert.IsFalse(TagRegistry.ValidateTag("x-aaaaaaaaa"));
            Assert.IsFalse(TagRegistry.ValidateTag("xaaaaaaaa"));
        }

        [TestMethod]
        public void TestGrandfatheredValidation()
        {
                        

            Assert.IsTrue(TagRegistry.ValidateTag("zh-xiang"));
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
            

            Assert.IsTrue(TagRegistry.ValidateTag("de"));//German
            Assert.IsTrue(TagRegistry.ValidateTag("fr"));//French
            Assert.IsTrue(TagRegistry.ValidateTag("ja"));//Japanese
            Assert.IsTrue(TagRegistry.ValidateTag("i-enochian"));//example of a grandfathered tag
        }

        [TestMethod]
        public void TestLanguageScriptValidation()
        {
            

            Assert.IsTrue(TagRegistry.ValidateTag("zh-Hant"));//Chinese written using the Traditional Chinese script
            Assert.IsTrue(TagRegistry.ValidateTag("zh-Hans"));//Chinese written using the Simplified Chinese script
            Assert.IsTrue(TagRegistry.ValidateTag("sr-Cyrl"));//Serbian written using the Cyrillic script
            Assert.IsTrue(TagRegistry.ValidateTag("sr-Latn"));//Serbian written using the Latin script
        }

        [TestMethod]
        public void TestExtendedLanguageSubtagsValidation()
        {
            

            Assert.IsTrue(TagRegistry.ValidateTag("zh-cmn-Hans-CN")); //Chinese, Mandarin, Simplified script, as used in China
            Assert.IsTrue(TagRegistry.ValidateTag("cmn-Hans-CN")); //Mandarin Chinese, Simplified script, as used in China
            Assert.IsTrue(TagRegistry.ValidateTag("zh-yue-HK")); //Chinese, Cantonese, as used in Hong Kong SAR
            Assert.IsTrue(TagRegistry.ValidateTag("yue-HK")); //Cantonese Chinese, as used in Hong Kong SAR
        }

        [TestMethod]
        public void TestLanguageScriptRegionValidation()
        {
            

            Assert.IsTrue(TagRegistry.ValidateTag("zh-Hans-CN")); //Chinese written using the Simplified script as used in mainland China
            Assert.IsTrue(TagRegistry.ValidateTag("sr-Latn-RS")); //Serbian written using the Latin script as used in Serbia
        }

        [TestMethod]
        public void TestLanguageVariantValidation()
        {
            

            Assert.IsTrue(TagRegistry.ValidateTag("sl-rozaj")); //Resian dialect of Slovenian
            Assert.IsTrue(TagRegistry.ValidateTag("sl-rozaj-biske")); //San Giorgio dialect of Resian dialect of Slovenian
            Assert.IsTrue(TagRegistry.ValidateTag("sl-nedis")); //Nadiza dialect of Slovenian
        }

        [TestMethod]
        public void TestLanguageRegionVariantValidation()
        {
            

            Assert.IsTrue(TagRegistry.ValidateTag("de-CH-1901")); //German as used in Switzerland using the 1901 variant [orthography]
            Assert.IsTrue(TagRegistry.ValidateTag("sl-IT-nedis")); //Slovenian as used in Italy, Nadiza dialect
        }

        [TestMethod]
        public void TestLanguageScriptRegionVariantValidation()
        {
            

            Assert.IsTrue(TagRegistry.ValidateTag("hy-Latn-IT-arevela")); //Eastern Armenian written in Latin script, as used in Italy
        }

        [TestMethod]
        public void TestLanguageRegionValidation()
        {
            

            Assert.IsTrue(TagRegistry.ValidateTag("de-DE")); //German for Germany
            Assert.IsTrue(TagRegistry.ValidateTag("en-US")); //English as used in the United States
            Assert.IsTrue(TagRegistry.ValidateTag("es-419"));//Spanish appropriate for the Latin America 
                                                          //  and Caribbean region using the UN region code
        }

        [TestMethod]
        public void TestPrivateUseSubtagValidation()
        {
            

            Assert.IsTrue(TagRegistry.ValidateTag("de-CH-x-phonebk"));
            Assert.IsTrue(TagRegistry.ValidateTag("az-Arab-x-AZE-derbend"));
        }

        [TestMethod]
        public void TestPrivateUseTagRegistryValuesValidation()
        {
            

            Assert.IsTrue(TagRegistry.ValidateTag("x-whatever")); //private use using the singleton 'x'
            Assert.IsTrue(TagRegistry.ValidateTag("qaa-Qaaa-QM-x-southern")); //all private tags
            Assert.IsTrue(TagRegistry.ValidateTag("de-Qaaa")); //German, with a private script
            Assert.IsTrue(TagRegistry.ValidateTag("sr-Latn-QM")); //Serbian, Latin script, private region
            Assert.IsTrue(TagRegistry.ValidateTag("sr-Qaaa-RS")); //Serbian, private script, for Serbia
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
