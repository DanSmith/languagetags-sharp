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
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("x-a"));
            Assert.IsTrue(registry.ValidateTag("x-aaaaaaaa"));
            Assert.IsTrue(registry.ValidateTag("x-a"));
            Assert.IsFalse(registry.ValidateTag("x-aaaaaaaaa"));
            Assert.IsFalse(registry.ValidateTag("xaaaaaaaa"));
        }

        [TestMethod]
        public void TestGrandfatheredValidation()
        {
            TagRegistry registry = new TagRegistry();            

            Assert.IsTrue(registry.ValidateTag("zh-xiang"));
        }



        [TestMethod]
        public void TestLanguageValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("de"));//German
            Assert.IsTrue(registry.ValidateTag("fr"));//French
            Assert.IsTrue(registry.ValidateTag("ja"));//Japanese
            Assert.IsTrue(registry.ValidateTag("i-enochian"));//example of a grandfathered tag
        }

        [TestMethod]
        public void TestLanguageScriptValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("zh-Hant"));//Chinese written using the Traditional Chinese script
            Assert.IsTrue(registry.ValidateTag("zh-Hans"));//Chinese written using the Simplified Chinese script
            Assert.IsTrue(registry.ValidateTag("sr-Cyrl"));//Serbian written using the Cyrillic script
            Assert.IsTrue(registry.ValidateTag("sr-Latn"));//Serbian written using the Latin script
        }

        [TestMethod]
        public void TestExtendedLanguageSubtagsValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("zh-cmn-Hans-CN")); //Chinese, Mandarin, Simplified script, as used in China
            Assert.IsTrue(registry.ValidateTag("cmn-Hans-CN")); //Mandarin Chinese, Simplified script, as used in China
            Assert.IsTrue(registry.ValidateTag("zh-yue-HK")); //Chinese, Cantonese, as used in Hong Kong SAR
            Assert.IsTrue(registry.ValidateTag("yue-HK")); //Cantonese Chinese, as used in Hong Kong SAR
        }

        [TestMethod]
        public void TestLanguageScriptRegionValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("zh-Hans-CN")); //Chinese written using the Simplified script as used in mainland China
            Assert.IsTrue(registry.ValidateTag("sr-Latn-RS")); //Serbian written using the Latin script as used in Serbia
        }

        [TestMethod]
        public void TestLanguageVariantValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("sl-rozaj")); //Resian dialect of Slovenian
            Assert.IsTrue(registry.ValidateTag("sl-rozaj-biske")); //San Giorgio dialect of Resian dialect of Slovenian
            Assert.IsTrue(registry.ValidateTag("sl-nedis")); //Nadiza dialect of Slovenian
        }

        [TestMethod]
        public void TestLanguageRegionVariantValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("de-CH-1901")); //German as used in Switzerland using the 1901 variant [orthography]
            Assert.IsTrue(registry.ValidateTag("sl-IT-nedis")); //Slovenian as used in Italy, Nadiza dialect
        }

        [TestMethod]
        public void TestLanguageScriptRegionVariantValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("hy-Latn-IT-arevela")); //Eastern Armenian written in Latin script, as used in Italy
        }

        [TestMethod]
        public void TestLanguageRegionValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("de-DE")); //German for Germany
            Assert.IsTrue(registry.ValidateTag("en-US")); //English as used in the United States
            Assert.IsTrue(registry.ValidateTag("es-419"));//Spanish appropriate for the Latin America 
                                                          //  and Caribbean region using the UN region code
        }

        [TestMethod]
        public void TestPrivateUseSubtagValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("de-CH-x-phonebk"));
            Assert.IsTrue(registry.ValidateTag("az-Arab-x-AZE-derbend"));
        }

        [TestMethod]
        public void TestPrivateUseRegistryValuesValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsTrue(registry.ValidateTag("x-whatever")); //private use using the singleton 'x'
            Assert.IsTrue(registry.ValidateTag("qaa-Qaaa-QM-x-southern")); //all private tags
            Assert.IsTrue(registry.ValidateTag("de-Qaaa")); //German, with a private script
            Assert.IsTrue(registry.ValidateTag("sr-Latn-QM")); //Serbian, Latin script, private region
            Assert.IsTrue(registry.ValidateTag("sr-Qaaa-RS")); //Serbian, private script, for Serbia
        }

        [TestMethod]
        public void TestInvalidValidation()
        {
            TagRegistry registry = new TagRegistry();

            Assert.IsFalse(registry.ValidateTag("de-419-DE")); //two region tags
            Assert.IsFalse(registry.ValidateTag("a-DE")); //(use of a single-character subtag in primary position; note
                                                          //that there are a few grandfathered tags that start with "i-" that are valid
            Assert.IsFalse(registry.ValidateTag("ar-a-aaa-b-bbb-a-ccc")); //two extensions with same single-letter prefix
        }
    }

}
