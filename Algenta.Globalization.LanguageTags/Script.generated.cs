using System;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;

namespace Algenta.Globalization.LanguageTags 
{

    public partial class Script 
    {

        private Script(string subtag, 
            string[] descriptions, 
            DateTime added, 
            string comment)
        {
            this.Subtag = subtag;
            this.descriptions = new ReadOnlyCollection<string>(descriptions);
            this.Added = added;
            this.Comments = comment;
        }

        public string Subtag { get; private set; }

        private ReadOnlyCollection<string> descriptions = null;
        public ReadOnlyCollection<string> Descriptions { get { return descriptions; } }
                
        public DateTime Added { get; private set; }
        public string Comments { get; private set; }

        #region static scripts
        #region Adlm
        /// <summary>
        /// Adlam
        /// </summary>
        public static Script Adlm { get { return _Adlm; } }
        private static Script _Adlm = new Script("Adlm", // Subtag
                                new string[]{ "Adlam" }, // Descriptions
                                new DateTime(2014, 12, 11 ), // Added
                                null); // Comments

        #endregion

        #region Afak
        /// <summary>
        /// Afaka
        /// </summary>
        public static Script Afak { get { return _Afak; } }
        private static Script _Afak = new Script("Afak", // Subtag
                                new string[]{ "Afaka" }, // Descriptions
                                new DateTime(2011, 1, 7 ), // Added
                                null); // Comments

        #endregion

        #region Aghb
        /// <summary>
        /// Caucasian Albanian
        /// </summary>
        public static Script Aghb { get { return _Aghb; } }
        private static Script _Aghb = new Script("Aghb", // Subtag
                                new string[]{ "Caucasian Albanian" }, // Descriptions
                                new DateTime(2012, 11, 1 ), // Added
                                null); // Comments

        #endregion

        #region Ahom
        /// <summary>
        /// Ahom
        /// Tai Ahom
        /// </summary>
        public static Script Ahom { get { return _Ahom; } }
        private static Script _Ahom = new Script("Ahom", // Subtag
                                new string[]{ "Ahom", "Tai Ahom" }, // Descriptions
                                new DateTime(2013, 12, 2 ), // Added
                                null); // Comments

        #endregion

        #region Arab
        /// <summary>
        /// Arabic
        /// </summary>
        public static Script Arab { get { return _Arab; } }
        private static Script _Arab = new Script("Arab", // Subtag
                                new string[]{ "Arabic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Aran
        /// <summary>
        /// Arabic (Nastaliq variant)
        /// </summary>
        public static Script Aran { get { return _Aran; } }
        private static Script _Aran = new Script("Aran", // Subtag
                                new string[]{ "Arabic (Nastaliq variant)" }, // Descriptions
                                new DateTime(2014, 12, 11 ), // Added
                                null); // Comments

        #endregion

        #region Armi
        /// <summary>
        /// Imperial Aramaic
        /// </summary>
        public static Script Armi { get { return _Armi; } }
        private static Script _Armi = new Script("Armi", // Subtag
                                new string[]{ "Imperial Aramaic" }, // Descriptions
                                new DateTime(2007, 12, 5 ), // Added
                                null); // Comments

        #endregion

        #region Armn
        /// <summary>
        /// Armenian
        /// </summary>
        public static Script Armn { get { return _Armn; } }
        private static Script _Armn = new Script("Armn", // Subtag
                                new string[]{ "Armenian" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Avst
        /// <summary>
        /// Avestan
        /// </summary>
        public static Script Avst { get { return _Avst; } }
        private static Script _Avst = new Script("Avst", // Subtag
                                new string[]{ "Avestan" }, // Descriptions
                                new DateTime(2007, 7, 28 ), // Added
                                null); // Comments

        #endregion

        #region Bali
        /// <summary>
        /// Balinese
        /// </summary>
        public static Script Bali { get { return _Bali; } }
        private static Script _Bali = new Script("Bali", // Subtag
                                new string[]{ "Balinese" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Bamu
        /// <summary>
        /// Bamum
        /// </summary>
        public static Script Bamu { get { return _Bamu; } }
        private static Script _Bamu = new Script("Bamu", // Subtag
                                new string[]{ "Bamum" }, // Descriptions
                                new DateTime(2009, 7, 30 ), // Added
                                null); // Comments

        #endregion

        #region Bass
        /// <summary>
        /// Bassa Vah
        /// </summary>
        public static Script Bass { get { return _Bass; } }
        private static Script _Bass = new Script("Bass", // Subtag
                                new string[]{ "Bassa Vah" }, // Descriptions
                                new DateTime(2010, 4, 10 ), // Added
                                null); // Comments

        #endregion

        #region Batk
        /// <summary>
        /// Batak
        /// </summary>
        public static Script Batk { get { return _Batk; } }
        private static Script _Batk = new Script("Batk", // Subtag
                                new string[]{ "Batak" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Beng
        /// <summary>
        /// Bengali
        /// Bangla
        /// </summary>
        public static Script Beng { get { return _Beng; } }
        private static Script _Beng = new Script("Beng", // Subtag
                                new string[]{ "Bengali", "Bangla" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Bhks
        /// <summary>
        /// Bhaiksuki
        /// </summary>
        public static Script Bhks { get { return _Bhks; } }
        private static Script _Bhks = new Script("Bhks", // Subtag
                                new string[]{ "Bhaiksuki" }, // Descriptions
                                new DateTime(2015, 7, 24 ), // Added
                                null); // Comments

        #endregion

        #region Blis
        /// <summary>
        /// Blissymbols
        /// </summary>
        public static Script Blis { get { return _Blis; } }
        private static Script _Blis = new Script("Blis", // Subtag
                                new string[]{ "Blissymbols" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Bopo
        /// <summary>
        /// Bopomofo
        /// </summary>
        public static Script Bopo { get { return _Bopo; } }
        private static Script _Bopo = new Script("Bopo", // Subtag
                                new string[]{ "Bopomofo" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Brah
        /// <summary>
        /// Brahmi
        /// </summary>
        public static Script Brah { get { return _Brah; } }
        private static Script _Brah = new Script("Brah", // Subtag
                                new string[]{ "Brahmi" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Brai
        /// <summary>
        /// Braille
        /// </summary>
        public static Script Brai { get { return _Brai; } }
        private static Script _Brai = new Script("Brai", // Subtag
                                new string[]{ "Braille" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Bugi
        /// <summary>
        /// Buginese
        /// </summary>
        public static Script Bugi { get { return _Bugi; } }
        private static Script _Bugi = new Script("Bugi", // Subtag
                                new string[]{ "Buginese" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Buhd
        /// <summary>
        /// Buhid
        /// </summary>
        public static Script Buhd { get { return _Buhd; } }
        private static Script _Buhd = new Script("Buhd", // Subtag
                                new string[]{ "Buhid" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Cakm
        /// <summary>
        /// Chakma
        /// </summary>
        public static Script Cakm { get { return _Cakm; } }
        private static Script _Cakm = new Script("Cakm", // Subtag
                                new string[]{ "Chakma" }, // Descriptions
                                new DateTime(2007, 12, 5 ), // Added
                                null); // Comments

        #endregion

        #region Cans
        /// <summary>
        /// Unified Canadian Aboriginal Syllabics
        /// </summary>
        public static Script Cans { get { return _Cans; } }
        private static Script _Cans = new Script("Cans", // Subtag
                                new string[]{ "Unified Canadian Aboriginal Syllabics" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Cari
        /// <summary>
        /// Carian
        /// </summary>
        public static Script Cari { get { return _Cari; } }
        private static Script _Cari = new Script("Cari", // Subtag
                                new string[]{ "Carian" }, // Descriptions
                                new DateTime(2006, 7, 21 ), // Added
                                null); // Comments

        #endregion

        #region Cham
        /// <summary>
        /// Cham
        /// </summary>
        public static Script Cham { get { return _Cham; } }
        private static Script _Cham = new Script("Cham", // Subtag
                                new string[]{ "Cham" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Cher
        /// <summary>
        /// Cherokee
        /// </summary>
        public static Script Cher { get { return _Cher; } }
        private static Script _Cher = new Script("Cher", // Subtag
                                new string[]{ "Cherokee" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Chrs
        /// <summary>
        /// Chorasmian
        /// </summary>
        public static Script Chrs { get { return _Chrs; } }
        private static Script _Chrs = new Script("Chrs", // Subtag
                                new string[]{ "Chorasmian" }, // Descriptions
                                new DateTime(2019, 9, 11 ), // Added
                                null); // Comments

        #endregion

        #region Cirt
        /// <summary>
        /// Cirth
        /// </summary>
        public static Script Cirt { get { return _Cirt; } }
        private static Script _Cirt = new Script("Cirt", // Subtag
                                new string[]{ "Cirth" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Copt
        /// <summary>
        /// Coptic
        /// </summary>
        public static Script Copt { get { return _Copt; } }
        private static Script _Copt = new Script("Copt", // Subtag
                                new string[]{ "Coptic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Cpmn
        /// <summary>
        /// Cypro-Minoan
        /// </summary>
        public static Script Cpmn { get { return _Cpmn; } }
        private static Script _Cpmn = new Script("Cpmn", // Subtag
                                new string[]{ "Cypro-Minoan" }, // Descriptions
                                new DateTime(2017, 8, 13 ), // Added
                                null); // Comments

        #endregion

        #region Cprt
        /// <summary>
        /// Cypriot syllabary
        /// </summary>
        public static Script Cprt { get { return _Cprt; } }
        private static Script _Cprt = new Script("Cprt", // Subtag
                                new string[]{ "Cypriot syllabary" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Cyrl
        /// <summary>
        /// Cyrillic
        /// </summary>
        public static Script Cyrl { get { return _Cyrl; } }
        private static Script _Cyrl = new Script("Cyrl", // Subtag
                                new string[]{ "Cyrillic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Cyrs
        /// <summary>
        /// Cyrillic (Old Church Slavonic variant)
        /// </summary>
        public static Script Cyrs { get { return _Cyrs; } }
        private static Script _Cyrs = new Script("Cyrs", // Subtag
                                new string[]{ "Cyrillic (Old Church Slavonic variant)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Deva
        /// <summary>
        /// Devanagari
        /// Nagari
        /// </summary>
        public static Script Deva { get { return _Deva; } }
        private static Script _Deva = new Script("Deva", // Subtag
                                new string[]{ "Devanagari", "Nagari" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Diak
        /// <summary>
        /// Dives Akuru
        /// </summary>
        public static Script Diak { get { return _Diak; } }
        private static Script _Diak = new Script("Diak", // Subtag
                                new string[]{ "Dives Akuru" }, // Descriptions
                                new DateTime(2019, 9, 11 ), // Added
                                null); // Comments

        #endregion

        #region Dogr
        /// <summary>
        /// Dogra
        /// </summary>
        public static Script Dogr { get { return _Dogr; } }
        private static Script _Dogr = new Script("Dogr", // Subtag
                                new string[]{ "Dogra" }, // Descriptions
                                new DateTime(2017, 1, 13 ), // Added
                                null); // Comments

        #endregion

        #region Dsrt
        /// <summary>
        /// Deseret
        /// Mormon
        /// </summary>
        public static Script Dsrt { get { return _Dsrt; } }
        private static Script _Dsrt = new Script("Dsrt", // Subtag
                                new string[]{ "Deseret", "Mormon" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Dupl
        /// <summary>
        /// Duployan shorthand
        /// Duployan stenography
        /// </summary>
        public static Script Dupl { get { return _Dupl; } }
        private static Script _Dupl = new Script("Dupl", // Subtag
                                new string[]{ "Duployan shorthand", "Duployan stenography" }, // Descriptions
                                new DateTime(2010, 8, 16 ), // Added
                                null); // Comments

        #endregion

        #region Egyd
        /// <summary>
        /// Egyptian demotic
        /// </summary>
        public static Script Egyd { get { return _Egyd; } }
        private static Script _Egyd = new Script("Egyd", // Subtag
                                new string[]{ "Egyptian demotic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Egyh
        /// <summary>
        /// Egyptian hieratic
        /// </summary>
        public static Script Egyh { get { return _Egyh; } }
        private static Script _Egyh = new Script("Egyh", // Subtag
                                new string[]{ "Egyptian hieratic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Egyp
        /// <summary>
        /// Egyptian hieroglyphs
        /// </summary>
        public static Script Egyp { get { return _Egyp; } }
        private static Script _Egyp = new Script("Egyp", // Subtag
                                new string[]{ "Egyptian hieroglyphs" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Elba
        /// <summary>
        /// Elbasan
        /// </summary>
        public static Script Elba { get { return _Elba; } }
        private static Script _Elba = new Script("Elba", // Subtag
                                new string[]{ "Elbasan" }, // Descriptions
                                new DateTime(2010, 8, 16 ), // Added
                                null); // Comments

        #endregion

        #region Elym
        /// <summary>
        /// Elymaic
        /// </summary>
        public static Script Elym { get { return _Elym; } }
        private static Script _Elym = new Script("Elym", // Subtag
                                new string[]{ "Elymaic" }, // Descriptions
                                new DateTime(2018, 10, 28 ), // Added
                                null); // Comments

        #endregion

        #region Ethi
        /// <summary>
        /// Ethiopic
        /// Geʻez
        /// Ge'ez
        /// </summary>
        public static Script Ethi { get { return _Ethi; } }
        private static Script _Ethi = new Script("Ethi", // Subtag
                                new string[]{ "Ethiopic", "Geʻez", "Ge'ez" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Geok
        /// <summary>
        /// Khutsuri (Asomtavruli and Nuskhuri)
        /// </summary>
        public static Script Geok { get { return _Geok; } }
        private static Script _Geok = new Script("Geok", // Subtag
                                new string[]{ "Khutsuri (Asomtavruli and Nuskhuri)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Geor
        /// <summary>
        /// Georgian (Mkhedruli and Mtavruli)
        /// </summary>
        public static Script Geor { get { return _Geor; } }
        private static Script _Geor = new Script("Geor", // Subtag
                                new string[]{ "Georgian (Mkhedruli and Mtavruli)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Glag
        /// <summary>
        /// Glagolitic
        /// </summary>
        public static Script Glag { get { return _Glag; } }
        private static Script _Glag = new Script("Glag", // Subtag
                                new string[]{ "Glagolitic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Gong
        /// <summary>
        /// Gunjala Gondi
        /// </summary>
        public static Script Gong { get { return _Gong; } }
        private static Script _Gong = new Script("Gong", // Subtag
                                new string[]{ "Gunjala Gondi" }, // Descriptions
                                new DateTime(2017, 1, 13 ), // Added
                                null); // Comments

        #endregion

        #region Gonm
        /// <summary>
        /// Masaram Gondi
        /// </summary>
        public static Script Gonm { get { return _Gonm; } }
        private static Script _Gonm = new Script("Gonm", // Subtag
                                new string[]{ "Masaram Gondi" }, // Descriptions
                                new DateTime(2017, 1, 13 ), // Added
                                null); // Comments

        #endregion

        #region Goth
        /// <summary>
        /// Gothic
        /// </summary>
        public static Script Goth { get { return _Goth; } }
        private static Script _Goth = new Script("Goth", // Subtag
                                new string[]{ "Gothic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Gran
        /// <summary>
        /// Grantha
        /// </summary>
        public static Script Gran { get { return _Gran; } }
        private static Script _Gran = new Script("Gran", // Subtag
                                new string[]{ "Grantha" }, // Descriptions
                                new DateTime(2009, 12, 9 ), // Added
                                null); // Comments

        #endregion

        #region Grek
        /// <summary>
        /// Greek
        /// </summary>
        public static Script Grek { get { return _Grek; } }
        private static Script _Grek = new Script("Grek", // Subtag
                                new string[]{ "Greek" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Gujr
        /// <summary>
        /// Gujarati
        /// </summary>
        public static Script Gujr { get { return _Gujr; } }
        private static Script _Gujr = new Script("Gujr", // Subtag
                                new string[]{ "Gujarati" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Guru
        /// <summary>
        /// Gurmukhi
        /// </summary>
        public static Script Guru { get { return _Guru; } }
        private static Script _Guru = new Script("Guru", // Subtag
                                new string[]{ "Gurmukhi" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Hanb
        /// <summary>
        /// Han with Bopomofo (alias for Han + Bopomofo)
        /// </summary>
        public static Script Hanb { get { return _Hanb; } }
        private static Script _Hanb = new Script("Hanb", // Subtag
                                new string[]{ "Han with Bopomofo (alias for Han + Bopomofo)" }, // Descriptions
                                new DateTime(2016, 2, 8 ), // Added
                                null); // Comments

        #endregion

        #region Hang
        /// <summary>
        /// Hangul
        /// Hangŭl
        /// Hangeul
        /// </summary>
        public static Script Hang { get { return _Hang; } }
        private static Script _Hang = new Script("Hang", // Subtag
                                new string[]{ "Hangul", "Hangŭl", "Hangeul" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Hani
        /// <summary>
        /// Han
        /// Hanzi
        /// Kanji
        /// Hanja
        /// </summary>
        public static Script Hani { get { return _Hani; } }
        private static Script _Hani = new Script("Hani", // Subtag
                                new string[]{ "Han", "Hanzi", "Kanji", "Hanja" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Hano
        /// <summary>
        /// Hanunoo
        /// Hanunóo
        /// </summary>
        public static Script Hano { get { return _Hano; } }
        private static Script _Hano = new Script("Hano", // Subtag
                                new string[]{ "Hanunoo", "Hanunóo" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Hans
        /// <summary>
        /// Han (Simplified variant)
        /// </summary>
        public static Script Hans { get { return _Hans; } }
        private static Script _Hans = new Script("Hans", // Subtag
                                new string[]{ "Han (Simplified variant)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Hant
        /// <summary>
        /// Han (Traditional variant)
        /// </summary>
        public static Script Hant { get { return _Hant; } }
        private static Script _Hant = new Script("Hant", // Subtag
                                new string[]{ "Han (Traditional variant)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Hatr
        /// <summary>
        /// Hatran
        /// </summary>
        public static Script Hatr { get { return _Hatr; } }
        private static Script _Hatr = new Script("Hatr", // Subtag
                                new string[]{ "Hatran" }, // Descriptions
                                new DateTime(2013, 12, 2 ), // Added
                                null); // Comments

        #endregion

        #region Hebr
        /// <summary>
        /// Hebrew
        /// </summary>
        public static Script Hebr { get { return _Hebr; } }
        private static Script _Hebr = new Script("Hebr", // Subtag
                                new string[]{ "Hebrew" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Hira
        /// <summary>
        /// Hiragana
        /// </summary>
        public static Script Hira { get { return _Hira; } }
        private static Script _Hira = new Script("Hira", // Subtag
                                new string[]{ "Hiragana" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Hluw
        /// <summary>
        /// Anatolian Hieroglyphs
        /// Luwian Hieroglyphs
        /// Hittite Hieroglyphs
        /// </summary>
        public static Script Hluw { get { return _Hluw; } }
        private static Script _Hluw = new Script("Hluw", // Subtag
                                new string[]{ "Anatolian Hieroglyphs", "Luwian Hieroglyphs", "Hittite Hieroglyphs" }, // Descriptions
                                new DateTime(2011, 12, 28 ), // Added
                                null); // Comments

        #endregion

        #region Hmng
        /// <summary>
        /// Pahawh Hmong
        /// </summary>
        public static Script Hmng { get { return _Hmng; } }
        private static Script _Hmng = new Script("Hmng", // Subtag
                                new string[]{ "Pahawh Hmong" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Hmnp
        /// <summary>
        /// Nyiakeng Puachue Hmong
        /// </summary>
        public static Script Hmnp { get { return _Hmnp; } }
        private static Script _Hmnp = new Script("Hmnp", // Subtag
                                new string[]{ "Nyiakeng Puachue Hmong" }, // Descriptions
                                new DateTime(2017, 8, 13 ), // Added
                                null); // Comments

        #endregion

        #region Hrkt
        /// <summary>
        /// Japanese syllabaries (alias for Hiragana + Katakana)
        /// </summary>
        public static Script Hrkt { get { return _Hrkt; } }
        private static Script _Hrkt = new Script("Hrkt", // Subtag
                                new string[]{ "Japanese syllabaries (alias for Hiragana + Katakana)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Hung
        /// <summary>
        /// Old Hungarian
        /// Hungarian Runic
        /// </summary>
        public static Script Hung { get { return _Hung; } }
        private static Script _Hung = new Script("Hung", // Subtag
                                new string[]{ "Old Hungarian", "Hungarian Runic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Inds
        /// <summary>
        /// Indus
        /// Harappan
        /// </summary>
        public static Script Inds { get { return _Inds; } }
        private static Script _Inds = new Script("Inds", // Subtag
                                new string[]{ "Indus", "Harappan" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Ital
        /// <summary>
        /// Old Italic (Etruscan, Oscan, etc.)
        /// </summary>
        public static Script Ital { get { return _Ital; } }
        private static Script _Ital = new Script("Ital", // Subtag
                                new string[]{ "Old Italic (Etruscan", " Oscan", " etc.)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Jamo
        /// <summary>
        /// Jamo (alias for Jamo subset of Hangul)
        /// </summary>
        public static Script Jamo { get { return _Jamo; } }
        private static Script _Jamo = new Script("Jamo", // Subtag
                                new string[]{ "Jamo (alias for Jamo subset of Hangul)" }, // Descriptions
                                new DateTime(2016, 2, 8 ), // Added
                                null); // Comments

        #endregion

        #region Java
        /// <summary>
        /// Javanese
        /// </summary>
        public static Script Java { get { return _Java; } }
        private static Script _Java = new Script("Java", // Subtag
                                new string[]{ "Javanese" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Jpan
        /// <summary>
        /// Japanese (alias for Han + Hiragana + Katakana)
        /// </summary>
        public static Script Jpan { get { return _Jpan; } }
        private static Script _Jpan = new Script("Jpan", // Subtag
                                new string[]{ "Japanese (alias for Han + Hiragana + Katakana)" }, // Descriptions
                                new DateTime(2006, 7, 21 ), // Added
                                null); // Comments

        #endregion

        #region Jurc
        /// <summary>
        /// Jurchen
        /// </summary>
        public static Script Jurc { get { return _Jurc; } }
        private static Script _Jurc = new Script("Jurc", // Subtag
                                new string[]{ "Jurchen" }, // Descriptions
                                new DateTime(2011, 1, 7 ), // Added
                                null); // Comments

        #endregion

        #region Kali
        /// <summary>
        /// Kayah Li
        /// </summary>
        public static Script Kali { get { return _Kali; } }
        private static Script _Kali = new Script("Kali", // Subtag
                                new string[]{ "Kayah Li" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Kana
        /// <summary>
        /// Katakana
        /// </summary>
        public static Script Kana { get { return _Kana; } }
        private static Script _Kana = new Script("Kana", // Subtag
                                new string[]{ "Katakana" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Kawi
        /// <summary>
        /// Kawi
        /// </summary>
        public static Script Kawi { get { return _Kawi; } }
        private static Script _Kawi = new Script("Kawi", // Subtag
                                new string[]{ "Kawi" }, // Descriptions
                                new DateTime(2021, 12, 24 ), // Added
                                null); // Comments

        #endregion

        #region Khar
        /// <summary>
        /// Kharoshthi
        /// </summary>
        public static Script Khar { get { return _Khar; } }
        private static Script _Khar = new Script("Khar", // Subtag
                                new string[]{ "Kharoshthi" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Khmr
        /// <summary>
        /// Khmer
        /// </summary>
        public static Script Khmr { get { return _Khmr; } }
        private static Script _Khmr = new Script("Khmr", // Subtag
                                new string[]{ "Khmer" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Khoj
        /// <summary>
        /// Khojki
        /// </summary>
        public static Script Khoj { get { return _Khoj; } }
        private static Script _Khoj = new Script("Khoj", // Subtag
                                new string[]{ "Khojki" }, // Descriptions
                                new DateTime(2011, 8, 16 ), // Added
                                null); // Comments

        #endregion

        #region Kitl
        /// <summary>
        /// Khitan large script
        /// </summary>
        public static Script Kitl { get { return _Kitl; } }
        private static Script _Kitl = new Script("Kitl", // Subtag
                                new string[]{ "Khitan large script" }, // Descriptions
                                new DateTime(2014, 12, 11 ), // Added
                                null); // Comments

        #endregion

        #region Kits
        /// <summary>
        /// Khitan small script
        /// </summary>
        public static Script Kits { get { return _Kits; } }
        private static Script _Kits = new Script("Kits", // Subtag
                                new string[]{ "Khitan small script" }, // Descriptions
                                new DateTime(2014, 12, 11 ), // Added
                                null); // Comments

        #endregion

        #region Knda
        /// <summary>
        /// Kannada
        /// </summary>
        public static Script Knda { get { return _Knda; } }
        private static Script _Knda = new Script("Knda", // Subtag
                                new string[]{ "Kannada" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Kore
        /// <summary>
        /// Korean (alias for Hangul + Han)
        /// </summary>
        public static Script Kore { get { return _Kore; } }
        private static Script _Kore = new Script("Kore", // Subtag
                                new string[]{ "Korean (alias for Hangul + Han)" }, // Descriptions
                                new DateTime(2007, 7, 5 ), // Added
                                null); // Comments

        #endregion

        #region Kpel
        /// <summary>
        /// Kpelle
        /// </summary>
        public static Script Kpel { get { return _Kpel; } }
        private static Script _Kpel = new Script("Kpel", // Subtag
                                new string[]{ "Kpelle" }, // Descriptions
                                new DateTime(2010, 4, 10 ), // Added
                                null); // Comments

        #endregion

        #region Kthi
        /// <summary>
        /// Kaithi
        /// </summary>
        public static Script Kthi { get { return _Kthi; } }
        private static Script _Kthi = new Script("Kthi", // Subtag
                                new string[]{ "Kaithi" }, // Descriptions
                                new DateTime(2007, 12, 5 ), // Added
                                null); // Comments

        #endregion

        #region Lana
        /// <summary>
        /// Tai Tham
        /// Lanna
        /// </summary>
        public static Script Lana { get { return _Lana; } }
        private static Script _Lana = new Script("Lana", // Subtag
                                new string[]{ "Tai Tham", "Lanna" }, // Descriptions
                                new DateTime(2006, 7, 21 ), // Added
                                null); // Comments

        #endregion

        #region Laoo
        /// <summary>
        /// Lao
        /// </summary>
        public static Script Laoo { get { return _Laoo; } }
        private static Script _Laoo = new Script("Laoo", // Subtag
                                new string[]{ "Lao" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Latf
        /// <summary>
        /// Latin (Fraktur variant)
        /// </summary>
        public static Script Latf { get { return _Latf; } }
        private static Script _Latf = new Script("Latf", // Subtag
                                new string[]{ "Latin (Fraktur variant)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Latg
        /// <summary>
        /// Latin (Gaelic variant)
        /// </summary>
        public static Script Latg { get { return _Latg; } }
        private static Script _Latg = new Script("Latg", // Subtag
                                new string[]{ "Latin (Gaelic variant)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Latn
        /// <summary>
        /// Latin
        /// </summary>
        public static Script Latn { get { return _Latn; } }
        private static Script _Latn = new Script("Latn", // Subtag
                                new string[]{ "Latin" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Leke
        /// <summary>
        /// Leke
        /// </summary>
        public static Script Leke { get { return _Leke; } }
        private static Script _Leke = new Script("Leke", // Subtag
                                new string[]{ "Leke" }, // Descriptions
                                new DateTime(2015, 7, 24 ), // Added
                                null); // Comments

        #endregion

        #region Lepc
        /// <summary>
        /// Lepcha
        /// Róng
        /// </summary>
        public static Script Lepc { get { return _Lepc; } }
        private static Script _Lepc = new Script("Lepc", // Subtag
                                new string[]{ "Lepcha", "Róng" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Limb
        /// <summary>
        /// Limbu
        /// </summary>
        public static Script Limb { get { return _Limb; } }
        private static Script _Limb = new Script("Limb", // Subtag
                                new string[]{ "Limbu" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Lina
        /// <summary>
        /// Linear A
        /// </summary>
        public static Script Lina { get { return _Lina; } }
        private static Script _Lina = new Script("Lina", // Subtag
                                new string[]{ "Linear A" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Linb
        /// <summary>
        /// Linear B
        /// </summary>
        public static Script Linb { get { return _Linb; } }
        private static Script _Linb = new Script("Linb", // Subtag
                                new string[]{ "Linear B" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Lisu
        /// <summary>
        /// Lisu
        /// Fraser
        /// </summary>
        public static Script Lisu { get { return _Lisu; } }
        private static Script _Lisu = new Script("Lisu", // Subtag
                                new string[]{ "Lisu", "Fraser" }, // Descriptions
                                new DateTime(2009, 3, 13 ), // Added
                                null); // Comments

        #endregion

        #region Loma
        /// <summary>
        /// Loma
        /// </summary>
        public static Script Loma { get { return _Loma; } }
        private static Script _Loma = new Script("Loma", // Subtag
                                new string[]{ "Loma" }, // Descriptions
                                new DateTime(2010, 4, 10 ), // Added
                                null); // Comments

        #endregion

        #region Lyci
        /// <summary>
        /// Lycian
        /// </summary>
        public static Script Lyci { get { return _Lyci; } }
        private static Script _Lyci = new Script("Lyci", // Subtag
                                new string[]{ "Lycian" }, // Descriptions
                                new DateTime(2006, 7, 21 ), // Added
                                null); // Comments

        #endregion

        #region Lydi
        /// <summary>
        /// Lydian
        /// </summary>
        public static Script Lydi { get { return _Lydi; } }
        private static Script _Lydi = new Script("Lydi", // Subtag
                                new string[]{ "Lydian" }, // Descriptions
                                new DateTime(2006, 7, 21 ), // Added
                                null); // Comments

        #endregion

        #region Mahj
        /// <summary>
        /// Mahajani
        /// </summary>
        public static Script Mahj { get { return _Mahj; } }
        private static Script _Mahj = new Script("Mahj", // Subtag
                                new string[]{ "Mahajani" }, // Descriptions
                                new DateTime(2012, 11, 1 ), // Added
                                null); // Comments

        #endregion

        #region Maka
        /// <summary>
        /// Makasar
        /// </summary>
        public static Script Maka { get { return _Maka; } }
        private static Script _Maka = new Script("Maka", // Subtag
                                new string[]{ "Makasar" }, // Descriptions
                                new DateTime(2017, 1, 13 ), // Added
                                null); // Comments

        #endregion

        #region Mand
        /// <summary>
        /// Mandaic
        /// Mandaean
        /// </summary>
        public static Script Mand { get { return _Mand; } }
        private static Script _Mand = new Script("Mand", // Subtag
                                new string[]{ "Mandaic", "Mandaean" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Mani
        /// <summary>
        /// Manichaean
        /// </summary>
        public static Script Mani { get { return _Mani; } }
        private static Script _Mani = new Script("Mani", // Subtag
                                new string[]{ "Manichaean" }, // Descriptions
                                new DateTime(2007, 7, 28 ), // Added
                                null); // Comments

        #endregion

        #region Marc
        /// <summary>
        /// Marchen
        /// </summary>
        public static Script Marc { get { return _Marc; } }
        private static Script _Marc = new Script("Marc", // Subtag
                                new string[]{ "Marchen" }, // Descriptions
                                new DateTime(2014, 12, 11 ), // Added
                                null); // Comments

        #endregion

        #region Maya
        /// <summary>
        /// Mayan hieroglyphs
        /// </summary>
        public static Script Maya { get { return _Maya; } }
        private static Script _Maya = new Script("Maya", // Subtag
                                new string[]{ "Mayan hieroglyphs" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Medf
        /// <summary>
        /// Medefaidrin
        /// Oberi Okaime
        /// Oberi Ɔkaimɛ
        /// </summary>
        public static Script Medf { get { return _Medf; } }
        private static Script _Medf = new Script("Medf", // Subtag
                                new string[]{ "Medefaidrin", "Oberi Okaime", "Oberi Ɔkaimɛ" }, // Descriptions
                                new DateTime(2017, 1, 13 ), // Added
                                null); // Comments

        #endregion

        #region Mend
        /// <summary>
        /// Mende Kikakui
        /// </summary>
        public static Script Mend { get { return _Mend; } }
        private static Script _Mend = new Script("Mend", // Subtag
                                new string[]{ "Mende Kikakui" }, // Descriptions
                                new DateTime(2010, 4, 10 ), // Added
                                null); // Comments

        #endregion

        #region Merc
        /// <summary>
        /// Meroitic Cursive
        /// </summary>
        public static Script Merc { get { return _Merc; } }
        private static Script _Merc = new Script("Merc", // Subtag
                                new string[]{ "Meroitic Cursive" }, // Descriptions
                                new DateTime(2009, 12, 9 ), // Added
                                null); // Comments

        #endregion

        #region Mero
        /// <summary>
        /// Meroitic Hieroglyphs
        /// </summary>
        public static Script Mero { get { return _Mero; } }
        private static Script _Mero = new Script("Mero", // Subtag
                                new string[]{ "Meroitic Hieroglyphs" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Mlym
        /// <summary>
        /// Malayalam
        /// </summary>
        public static Script Mlym { get { return _Mlym; } }
        private static Script _Mlym = new Script("Mlym", // Subtag
                                new string[]{ "Malayalam" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Modi
        /// <summary>
        /// Modi
        /// Moḍī
        /// </summary>
        public static Script Modi { get { return _Modi; } }
        private static Script _Modi = new Script("Modi", // Subtag
                                new string[]{ "Modi", "Moḍī" }, // Descriptions
                                new DateTime(2013, 12, 2 ), // Added
                                null); // Comments

        #endregion

        #region Mong
        /// <summary>
        /// Mongolian
        /// </summary>
        public static Script Mong { get { return _Mong; } }
        private static Script _Mong = new Script("Mong", // Subtag
                                new string[]{ "Mongolian" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Moon
        /// <summary>
        /// Moon
        /// Moon code
        /// Moon script
        /// Moon type
        /// </summary>
        public static Script Moon { get { return _Moon; } }
        private static Script _Moon = new Script("Moon", // Subtag
                                new string[]{ "Moon", "Moon code", "Moon script", "Moon type" }, // Descriptions
                                new DateTime(2007, 1, 26 ), // Added
                                null); // Comments

        #endregion

        #region Mroo
        /// <summary>
        /// Mro
        /// Mru
        /// </summary>
        public static Script Mroo { get { return _Mroo; } }
        private static Script _Mroo = new Script("Mroo", // Subtag
                                new string[]{ "Mro", "Mru" }, // Descriptions
                                new DateTime(2011, 1, 7 ), // Added
                                null); // Comments

        #endregion

        #region Mtei
        /// <summary>
        /// Meitei Mayek
        /// Meithei
        /// Meetei
        /// </summary>
        public static Script Mtei { get { return _Mtei; } }
        private static Script _Mtei = new Script("Mtei", // Subtag
                                new string[]{ "Meitei Mayek", "Meithei", "Meetei" }, // Descriptions
                                new DateTime(2007, 1, 26 ), // Added
                                null); // Comments

        #endregion

        #region Mult
        /// <summary>
        /// Multani
        /// </summary>
        public static Script Mult { get { return _Mult; } }
        private static Script _Mult = new Script("Mult", // Subtag
                                new string[]{ "Multani" }, // Descriptions
                                new DateTime(2013, 12, 2 ), // Added
                                null); // Comments

        #endregion

        #region Mymr
        /// <summary>
        /// Myanmar
        /// Burmese
        /// </summary>
        public static Script Mymr { get { return _Mymr; } }
        private static Script _Mymr = new Script("Mymr", // Subtag
                                new string[]{ "Myanmar", "Burmese" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Nagm
        /// <summary>
        /// Nag Mundari
        /// </summary>
        public static Script Nagm { get { return _Nagm; } }
        private static Script _Nagm = new Script("Nagm", // Subtag
                                new string[]{ "Nag Mundari" }, // Descriptions
                                new DateTime(2021, 12, 24 ), // Added
                                null); // Comments

        #endregion

        #region Nand
        /// <summary>
        /// Nandinagari
        /// </summary>
        public static Script Nand { get { return _Nand; } }
        private static Script _Nand = new Script("Nand", // Subtag
                                new string[]{ "Nandinagari" }, // Descriptions
                                new DateTime(2018, 10, 28 ), // Added
                                null); // Comments

        #endregion

        #region Narb
        /// <summary>
        /// Old North Arabian
        /// Ancient North Arabian
        /// </summary>
        public static Script Narb { get { return _Narb; } }
        private static Script _Narb = new Script("Narb", // Subtag
                                new string[]{ "Old North Arabian", "Ancient North Arabian" }, // Descriptions
                                new DateTime(2010, 4, 10 ), // Added
                                null); // Comments

        #endregion

        #region Nbat
        /// <summary>
        /// Nabataean
        /// </summary>
        public static Script Nbat { get { return _Nbat; } }
        private static Script _Nbat = new Script("Nbat", // Subtag
                                new string[]{ "Nabataean" }, // Descriptions
                                new DateTime(2010, 4, 10 ), // Added
                                null); // Comments

        #endregion

        #region Newa
        /// <summary>
        /// Newa
        /// Newar
        /// Newari
        /// Nepāla lipi
        /// </summary>
        public static Script Newa { get { return _Newa; } }
        private static Script _Newa = new Script("Newa", // Subtag
                                new string[]{ "Newa", "Newar", "Newari", "Nepāla lipi" }, // Descriptions
                                new DateTime(2016, 1, 4 ), // Added
                                null); // Comments

        #endregion

        #region Nkdb
        /// <summary>
        /// Naxi Dongba
        /// na²¹ɕi³³ to³³ba²¹
        /// Nakhi Tomba
        /// </summary>
        public static Script Nkdb { get { return _Nkdb; } }
        private static Script _Nkdb = new Script("Nkdb", // Subtag
                                new string[]{ "Naxi Dongba", "na²¹ɕi³³ to³³ba²¹", "Nakhi Tomba" }, // Descriptions
                                new DateTime(2017, 8, 13 ), // Added
                                null); // Comments

        #endregion

        #region Nkgb
        /// <summary>
        /// Naxi Geba
        /// na²¹ɕi³³ gʌ²¹ba²¹
        /// 'Na-'Khi ²Ggŏ-¹baw
        /// Nakhi Geba
        /// </summary>
        public static Script Nkgb { get { return _Nkgb; } }
        private static Script _Nkgb = new Script("Nkgb", // Subtag
                                new string[]{ "Naxi Geba", "na²¹ɕi³³ gʌ²¹ba²¹", "'Na-'Khi ²Ggŏ-¹baw", "Nakhi Geba" }, // Descriptions
                                new DateTime(2009, 3, 13 ), // Added
                                null); // Comments

        #endregion

        #region Nkoo
        /// <summary>
        /// N’Ko
        /// N'Ko
        /// </summary>
        public static Script Nkoo { get { return _Nkoo; } }
        private static Script _Nkoo = new Script("Nkoo", // Subtag
                                new string[]{ "N’Ko", "N'Ko" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Nshu
        /// <summary>
        /// Nüshu
        /// </summary>
        public static Script Nshu { get { return _Nshu; } }
        private static Script _Nshu = new Script("Nshu", // Subtag
                                new string[]{ "Nüshu" }, // Descriptions
                                new DateTime(2011, 1, 7 ), // Added
                                null); // Comments

        #endregion

        #region Ogam
        /// <summary>
        /// Ogham
        /// </summary>
        public static Script Ogam { get { return _Ogam; } }
        private static Script _Ogam = new Script("Ogam", // Subtag
                                new string[]{ "Ogham" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Olck
        /// <summary>
        /// Ol Chiki
        /// Ol Cemet'
        /// Ol
        /// Santali
        /// </summary>
        public static Script Olck { get { return _Olck; } }
        private static Script _Olck = new Script("Olck", // Subtag
                                new string[]{ "Ol Chiki", "Ol Cemet'", "Ol", "Santali" }, // Descriptions
                                new DateTime(2006, 7, 21 ), // Added
                                null); // Comments

        #endregion

        #region Orkh
        /// <summary>
        /// Old Turkic
        /// Orkhon Runic
        /// </summary>
        public static Script Orkh { get { return _Orkh; } }
        private static Script _Orkh = new Script("Orkh", // Subtag
                                new string[]{ "Old Turkic", "Orkhon Runic" }, // Descriptions
                                new DateTime(2009, 7, 30 ), // Added
                                null); // Comments

        #endregion

        #region Orya
        /// <summary>
        /// Oriya
        /// Odia
        /// </summary>
        public static Script Orya { get { return _Orya; } }
        private static Script _Orya = new Script("Orya", // Subtag
                                new string[]{ "Oriya", "Odia" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Osge
        /// <summary>
        /// Osage
        /// </summary>
        public static Script Osge { get { return _Osge; } }
        private static Script _Osge = new Script("Osge", // Subtag
                                new string[]{ "Osage" }, // Descriptions
                                new DateTime(2014, 12, 11 ), // Added
                                null); // Comments

        #endregion

        #region Osma
        /// <summary>
        /// Osmanya
        /// </summary>
        public static Script Osma { get { return _Osma; } }
        private static Script _Osma = new Script("Osma", // Subtag
                                new string[]{ "Osmanya" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Ougr
        /// <summary>
        /// Old Uyghur
        /// </summary>
        public static Script Ougr { get { return _Ougr; } }
        private static Script _Ougr = new Script("Ougr", // Subtag
                                new string[]{ "Old Uyghur" }, // Descriptions
                                new DateTime(2021, 2, 12 ), // Added
                                null); // Comments

        #endregion

        #region Palm
        /// <summary>
        /// Palmyrene
        /// </summary>
        public static Script Palm { get { return _Palm; } }
        private static Script _Palm = new Script("Palm", // Subtag
                                new string[]{ "Palmyrene" }, // Descriptions
                                new DateTime(2010, 4, 10 ), // Added
                                null); // Comments

        #endregion

        #region Pauc
        /// <summary>
        /// Pau Cin Hau
        /// </summary>
        public static Script Pauc { get { return _Pauc; } }
        private static Script _Pauc = new Script("Pauc", // Subtag
                                new string[]{ "Pau Cin Hau" }, // Descriptions
                                new DateTime(2013, 12, 2 ), // Added
                                null); // Comments

        #endregion

        #region Pcun
        /// <summary>
        /// Proto-Cuneiform
        /// </summary>
        public static Script Pcun { get { return _Pcun; } }
        private static Script _Pcun = new Script("Pcun", // Subtag
                                new string[]{ "Proto-Cuneiform" }, // Descriptions
                                new DateTime(2021, 2, 12 ), // Added
                                null); // Comments

        #endregion

        #region Pelm
        /// <summary>
        /// Proto-Elamite
        /// </summary>
        public static Script Pelm { get { return _Pelm; } }
        private static Script _Pelm = new Script("Pelm", // Subtag
                                new string[]{ "Proto-Elamite" }, // Descriptions
                                new DateTime(2021, 2, 12 ), // Added
                                null); // Comments

        #endregion

        #region Perm
        /// <summary>
        /// Old Permic
        /// </summary>
        public static Script Perm { get { return _Perm; } }
        private static Script _Perm = new Script("Perm", // Subtag
                                new string[]{ "Old Permic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Phag
        /// <summary>
        /// Phags-pa
        /// </summary>
        public static Script Phag { get { return _Phag; } }
        private static Script _Phag = new Script("Phag", // Subtag
                                new string[]{ "Phags-pa" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Phli
        /// <summary>
        /// Inscriptional Pahlavi
        /// </summary>
        public static Script Phli { get { return _Phli; } }
        private static Script _Phli = new Script("Phli", // Subtag
                                new string[]{ "Inscriptional Pahlavi" }, // Descriptions
                                new DateTime(2007, 12, 5 ), // Added
                                null); // Comments

        #endregion

        #region Phlp
        /// <summary>
        /// Psalter Pahlavi
        /// </summary>
        public static Script Phlp { get { return _Phlp; } }
        private static Script _Phlp = new Script("Phlp", // Subtag
                                new string[]{ "Psalter Pahlavi" }, // Descriptions
                                new DateTime(2007, 12, 5 ), // Added
                                null); // Comments

        #endregion

        #region Phlv
        /// <summary>
        /// Book Pahlavi
        /// </summary>
        public static Script Phlv { get { return _Phlv; } }
        private static Script _Phlv = new Script("Phlv", // Subtag
                                new string[]{ "Book Pahlavi" }, // Descriptions
                                new DateTime(2007, 7, 28 ), // Added
                                null); // Comments

        #endregion

        #region Phnx
        /// <summary>
        /// Phoenician
        /// </summary>
        public static Script Phnx { get { return _Phnx; } }
        private static Script _Phnx = new Script("Phnx", // Subtag
                                new string[]{ "Phoenician" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Piqd
        /// <summary>
        /// Klingon (KLI pIqaD)
        /// </summary>
        public static Script Piqd { get { return _Piqd; } }
        private static Script _Piqd = new Script("Piqd", // Subtag
                                new string[]{ "Klingon (KLI pIqaD)" }, // Descriptions
                                new DateTime(2016, 1, 4 ), // Added
                                null); // Comments

        #endregion

        #region Plrd
        /// <summary>
        /// Miao
        /// Pollard
        /// </summary>
        public static Script Plrd { get { return _Plrd; } }
        private static Script _Plrd = new Script("Plrd", // Subtag
                                new string[]{ "Miao", "Pollard" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Prti
        /// <summary>
        /// Inscriptional Parthian
        /// </summary>
        public static Script Prti { get { return _Prti; } }
        private static Script _Prti = new Script("Prti", // Subtag
                                new string[]{ "Inscriptional Parthian" }, // Descriptions
                                new DateTime(2007, 12, 5 ), // Added
                                null); // Comments

        #endregion

        #region Psin
        /// <summary>
        /// Proto-Sinaitic
        /// </summary>
        public static Script Psin { get { return _Psin; } }
        private static Script _Psin = new Script("Psin", // Subtag
                                new string[]{ "Proto-Sinaitic" }, // Descriptions
                                new DateTime(2021, 2, 12 ), // Added
                                null); // Comments

        #endregion

        #region Qaaa
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaaa { get { return _Qaaa; } }
        private static Script _Qaaa = new Script("qaaa", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaab
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaab { get { return _Qaab; } }
        private static Script _Qaab = new Script("qaab", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaac
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaac { get { return _Qaac; } }
        private static Script _Qaac = new Script("qaac", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaad
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaad { get { return _Qaad; } }
        private static Script _Qaad = new Script("qaad", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaae
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaae { get { return _Qaae; } }
        private static Script _Qaae = new Script("qaae", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaaf
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaaf { get { return _Qaaf; } }
        private static Script _Qaaf = new Script("qaaf", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaag
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaag { get { return _Qaag; } }
        private static Script _Qaag = new Script("qaag", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaah
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaah { get { return _Qaah; } }
        private static Script _Qaah = new Script("qaah", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaai
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaai { get { return _Qaai; } }
        private static Script _Qaai = new Script("qaai", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaaj
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaaj { get { return _Qaaj; } }
        private static Script _Qaaj = new Script("qaaj", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaak
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaak { get { return _Qaak; } }
        private static Script _Qaak = new Script("qaak", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaal
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaal { get { return _Qaal; } }
        private static Script _Qaal = new Script("qaal", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaam
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaam { get { return _Qaam; } }
        private static Script _Qaam = new Script("qaam", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaan
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaan { get { return _Qaan; } }
        private static Script _Qaan = new Script("qaan", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaao
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaao { get { return _Qaao; } }
        private static Script _Qaao = new Script("qaao", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaap
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaap { get { return _Qaap; } }
        private static Script _Qaap = new Script("qaap", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaaq
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaaq { get { return _Qaaq; } }
        private static Script _Qaaq = new Script("qaaq", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaar
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaar { get { return _Qaar; } }
        private static Script _Qaar = new Script("qaar", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaas
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaas { get { return _Qaas; } }
        private static Script _Qaas = new Script("qaas", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaat
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaat { get { return _Qaat; } }
        private static Script _Qaat = new Script("qaat", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaau
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaau { get { return _Qaau; } }
        private static Script _Qaau = new Script("qaau", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaav
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaav { get { return _Qaav; } }
        private static Script _Qaav = new Script("qaav", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaaw
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaaw { get { return _Qaaw; } }
        private static Script _Qaaw = new Script("qaaw", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaax
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaax { get { return _Qaax; } }
        private static Script _Qaax = new Script("qaax", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaay
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaay { get { return _Qaay; } }
        private static Script _Qaay = new Script("qaay", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaaz
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaaz { get { return _Qaaz; } }
        private static Script _Qaaz = new Script("qaaz", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qaba
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qaba { get { return _Qaba; } }
        private static Script _Qaba = new Script("qaba", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabb
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabb { get { return _Qabb; } }
        private static Script _Qabb = new Script("qabb", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabc
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabc { get { return _Qabc; } }
        private static Script _Qabc = new Script("qabc", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabd
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabd { get { return _Qabd; } }
        private static Script _Qabd = new Script("qabd", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabe
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabe { get { return _Qabe; } }
        private static Script _Qabe = new Script("qabe", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabf
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabf { get { return _Qabf; } }
        private static Script _Qabf = new Script("qabf", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabg
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabg { get { return _Qabg; } }
        private static Script _Qabg = new Script("qabg", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabh
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabh { get { return _Qabh; } }
        private static Script _Qabh = new Script("qabh", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabi
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabi { get { return _Qabi; } }
        private static Script _Qabi = new Script("qabi", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabj
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabj { get { return _Qabj; } }
        private static Script _Qabj = new Script("qabj", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabk
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabk { get { return _Qabk; } }
        private static Script _Qabk = new Script("qabk", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabl
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabl { get { return _Qabl; } }
        private static Script _Qabl = new Script("qabl", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabm
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabm { get { return _Qabm; } }
        private static Script _Qabm = new Script("qabm", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabn
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabn { get { return _Qabn; } }
        private static Script _Qabn = new Script("qabn", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabo
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabo { get { return _Qabo; } }
        private static Script _Qabo = new Script("qabo", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabp
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabp { get { return _Qabp; } }
        private static Script _Qabp = new Script("qabp", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabq
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabq { get { return _Qabq; } }
        private static Script _Qabq = new Script("qabq", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabr
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabr { get { return _Qabr; } }
        private static Script _Qabr = new Script("qabr", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabs
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabs { get { return _Qabs; } }
        private static Script _Qabs = new Script("qabs", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabt
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabt { get { return _Qabt; } }
        private static Script _Qabt = new Script("qabt", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabu
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabu { get { return _Qabu; } }
        private static Script _Qabu = new Script("qabu", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabv
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabv { get { return _Qabv; } }
        private static Script _Qabv = new Script("qabv", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabw
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabw { get { return _Qabw; } }
        private static Script _Qabw = new Script("qabw", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Qabx
        /// <summary>
        /// Private use
        /// </summary>
        public static Script Qabx { get { return _Qabx; } }
        private static Script _Qabx = new Script("qabx", // Subtag
                                new string[]{ "Private use" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Ranj
        /// <summary>
        /// Ranjana
        /// </summary>
        public static Script Ranj { get { return _Ranj; } }
        private static Script _Ranj = new Script("Ranj", // Subtag
                                new string[]{ "Ranjana" }, // Descriptions
                                new DateTime(2021, 2, 12 ), // Added
                                null); // Comments

        #endregion

        #region Rjng
        /// <summary>
        /// Rejang
        /// Redjang
        /// Kaganga
        /// </summary>
        public static Script Rjng { get { return _Rjng; } }
        private static Script _Rjng = new Script("Rjng", // Subtag
                                new string[]{ "Rejang", "Redjang", "Kaganga" }, // Descriptions
                                new DateTime(2006, 10, 17 ), // Added
                                null); // Comments

        #endregion

        #region Rohg
        /// <summary>
        /// Hanifi Rohingya
        /// </summary>
        public static Script Rohg { get { return _Rohg; } }
        private static Script _Rohg = new Script("Rohg", // Subtag
                                new string[]{ "Hanifi Rohingya" }, // Descriptions
                                new DateTime(2017, 12, 13 ), // Added
                                null); // Comments

        #endregion

        #region Roro
        /// <summary>
        /// Rongorongo
        /// </summary>
        public static Script Roro { get { return _Roro; } }
        private static Script _Roro = new Script("Roro", // Subtag
                                new string[]{ "Rongorongo" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Runr
        /// <summary>
        /// Runic
        /// </summary>
        public static Script Runr { get { return _Runr; } }
        private static Script _Runr = new Script("Runr", // Subtag
                                new string[]{ "Runic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Samr
        /// <summary>
        /// Samaritan
        /// </summary>
        public static Script Samr { get { return _Samr; } }
        private static Script _Samr = new Script("Samr", // Subtag
                                new string[]{ "Samaritan" }, // Descriptions
                                new DateTime(2007, 7, 28 ), // Added
                                null); // Comments

        #endregion

        #region Sara
        /// <summary>
        /// Sarati
        /// </summary>
        public static Script Sara { get { return _Sara; } }
        private static Script _Sara = new Script("Sara", // Subtag
                                new string[]{ "Sarati" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Sarb
        /// <summary>
        /// Old South Arabian
        /// </summary>
        public static Script Sarb { get { return _Sarb; } }
        private static Script _Sarb = new Script("Sarb", // Subtag
                                new string[]{ "Old South Arabian" }, // Descriptions
                                new DateTime(2009, 7, 30 ), // Added
                                null); // Comments

        #endregion

        #region Saur
        /// <summary>
        /// Saurashtra
        /// </summary>
        public static Script Saur { get { return _Saur; } }
        private static Script _Saur = new Script("Saur", // Subtag
                                new string[]{ "Saurashtra" }, // Descriptions
                                new DateTime(2006, 7, 21 ), // Added
                                null); // Comments

        #endregion

        #region Sgnw
        /// <summary>
        /// SignWriting
        /// </summary>
        public static Script Sgnw { get { return _Sgnw; } }
        private static Script _Sgnw = new Script("Sgnw", // Subtag
                                new string[]{ "SignWriting" }, // Descriptions
                                new DateTime(2006, 10, 17 ), // Added
                                null); // Comments

        #endregion

        #region Shaw
        /// <summary>
        /// Shavian
        /// Shaw
        /// </summary>
        public static Script Shaw { get { return _Shaw; } }
        private static Script _Shaw = new Script("Shaw", // Subtag
                                new string[]{ "Shavian", "Shaw" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Shrd
        /// <summary>
        /// Sharada
        /// Śāradā
        /// </summary>
        public static Script Shrd { get { return _Shrd; } }
        private static Script _Shrd = new Script("Shrd", // Subtag
                                new string[]{ "Sharada", "Śāradā" }, // Descriptions
                                new DateTime(2011, 1, 7 ), // Added
                                null); // Comments

        #endregion

        #region Shui
        /// <summary>
        /// Shuishu
        /// </summary>
        public static Script Shui { get { return _Shui; } }
        private static Script _Shui = new Script("Shui", // Subtag
                                new string[]{ "Shuishu" }, // Descriptions
                                new DateTime(2017, 8, 13 ), // Added
                                null); // Comments

        #endregion

        #region Sidd
        /// <summary>
        /// Siddham
        /// Siddhaṃ
        /// Siddhamātṛkā
        /// </summary>
        public static Script Sidd { get { return _Sidd; } }
        private static Script _Sidd = new Script("Sidd", // Subtag
                                new string[]{ "Siddham", "Siddhaṃ", "Siddhamātṛkā" }, // Descriptions
                                new DateTime(2013, 12, 2 ), // Added
                                null); // Comments

        #endregion

        #region Sind
        /// <summary>
        /// Khudawadi
        /// Sindhi
        /// </summary>
        public static Script Sind { get { return _Sind; } }
        private static Script _Sind = new Script("Sind", // Subtag
                                new string[]{ "Khudawadi", "Sindhi" }, // Descriptions
                                new DateTime(2010, 8, 16 ), // Added
                                null); // Comments

        #endregion

        #region Sinh
        /// <summary>
        /// Sinhala
        /// </summary>
        public static Script Sinh { get { return _Sinh; } }
        private static Script _Sinh = new Script("Sinh", // Subtag
                                new string[]{ "Sinhala" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Sogd
        /// <summary>
        /// Sogdian
        /// </summary>
        public static Script Sogd { get { return _Sogd; } }
        private static Script _Sogd = new Script("Sogd", // Subtag
                                new string[]{ "Sogdian" }, // Descriptions
                                new DateTime(2017, 12, 13 ), // Added
                                null); // Comments

        #endregion

        #region Sogo
        /// <summary>
        /// Old Sogdian
        /// </summary>
        public static Script Sogo { get { return _Sogo; } }
        private static Script _Sogo = new Script("Sogo", // Subtag
                                new string[]{ "Old Sogdian" }, // Descriptions
                                new DateTime(2017, 12, 13 ), // Added
                                null); // Comments

        #endregion

        #region Sora
        /// <summary>
        /// Sora Sompeng
        /// </summary>
        public static Script Sora { get { return _Sora; } }
        private static Script _Sora = new Script("Sora", // Subtag
                                new string[]{ "Sora Sompeng" }, // Descriptions
                                new DateTime(2011, 1, 7 ), // Added
                                null); // Comments

        #endregion

        #region Soyo
        /// <summary>
        /// Soyombo
        /// </summary>
        public static Script Soyo { get { return _Soyo; } }
        private static Script _Soyo = new Script("Soyo", // Subtag
                                new string[]{ "Soyombo" }, // Descriptions
                                new DateTime(2017, 1, 13 ), // Added
                                null); // Comments

        #endregion

        #region Sund
        /// <summary>
        /// Sundanese
        /// </summary>
        public static Script Sund { get { return _Sund; } }
        private static Script _Sund = new Script("Sund", // Subtag
                                new string[]{ "Sundanese" }, // Descriptions
                                new DateTime(2006, 7, 21 ), // Added
                                null); // Comments

        #endregion

        #region Sunu
        /// <summary>
        /// Sunuwar
        /// </summary>
        public static Script Sunu { get { return _Sunu; } }
        private static Script _Sunu = new Script("Sunu", // Subtag
                                new string[]{ "Sunuwar" }, // Descriptions
                                new DateTime(2021, 12, 24 ), // Added
                                null); // Comments

        #endregion

        #region Sylo
        /// <summary>
        /// Syloti Nagri
        /// </summary>
        public static Script Sylo { get { return _Sylo; } }
        private static Script _Sylo = new Script("Sylo", // Subtag
                                new string[]{ "Syloti Nagri" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Syrc
        /// <summary>
        /// Syriac
        /// </summary>
        public static Script Syrc { get { return _Syrc; } }
        private static Script _Syrc = new Script("Syrc", // Subtag
                                new string[]{ "Syriac" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Syre
        /// <summary>
        /// Syriac (Estrangelo variant)
        /// </summary>
        public static Script Syre { get { return _Syre; } }
        private static Script _Syre = new Script("Syre", // Subtag
                                new string[]{ "Syriac (Estrangelo variant)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Syrj
        /// <summary>
        /// Syriac (Western variant)
        /// </summary>
        public static Script Syrj { get { return _Syrj; } }
        private static Script _Syrj = new Script("Syrj", // Subtag
                                new string[]{ "Syriac (Western variant)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Syrn
        /// <summary>
        /// Syriac (Eastern variant)
        /// </summary>
        public static Script Syrn { get { return _Syrn; } }
        private static Script _Syrn = new Script("Syrn", // Subtag
                                new string[]{ "Syriac (Eastern variant)" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Tagb
        /// <summary>
        /// Tagbanwa
        /// </summary>
        public static Script Tagb { get { return _Tagb; } }
        private static Script _Tagb = new Script("Tagb", // Subtag
                                new string[]{ "Tagbanwa" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Takr
        /// <summary>
        /// Takri
        /// Ṭākrī
        /// Ṭāṅkrī
        /// </summary>
        public static Script Takr { get { return _Takr; } }
        private static Script _Takr = new Script("Takr", // Subtag
                                new string[]{ "Takri", "Ṭākrī", "Ṭāṅkrī" }, // Descriptions
                                new DateTime(2011, 1, 7 ), // Added
                                null); // Comments

        #endregion

        #region Tale
        /// <summary>
        /// Tai Le
        /// </summary>
        public static Script Tale { get { return _Tale; } }
        private static Script _Tale = new Script("Tale", // Subtag
                                new string[]{ "Tai Le" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Talu
        /// <summary>
        /// New Tai Lue
        /// </summary>
        public static Script Talu { get { return _Talu; } }
        private static Script _Talu = new Script("Talu", // Subtag
                                new string[]{ "New Tai Lue" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Taml
        /// <summary>
        /// Tamil
        /// </summary>
        public static Script Taml { get { return _Taml; } }
        private static Script _Taml = new Script("Taml", // Subtag
                                new string[]{ "Tamil" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Tang
        /// <summary>
        /// Tangut
        /// </summary>
        public static Script Tang { get { return _Tang; } }
        private static Script _Tang = new Script("Tang", // Subtag
                                new string[]{ "Tangut" }, // Descriptions
                                new DateTime(2011, 1, 7 ), // Added
                                null); // Comments

        #endregion

        #region Tavt
        /// <summary>
        /// Tai Viet
        /// </summary>
        public static Script Tavt { get { return _Tavt; } }
        private static Script _Tavt = new Script("Tavt", // Subtag
                                new string[]{ "Tai Viet" }, // Descriptions
                                new DateTime(2007, 12, 5 ), // Added
                                null); // Comments

        #endregion

        #region Telu
        /// <summary>
        /// Telugu
        /// </summary>
        public static Script Telu { get { return _Telu; } }
        private static Script _Telu = new Script("Telu", // Subtag
                                new string[]{ "Telugu" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Teng
        /// <summary>
        /// Tengwar
        /// </summary>
        public static Script Teng { get { return _Teng; } }
        private static Script _Teng = new Script("Teng", // Subtag
                                new string[]{ "Tengwar" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Tfng
        /// <summary>
        /// Tifinagh
        /// Berber
        /// </summary>
        public static Script Tfng { get { return _Tfng; } }
        private static Script _Tfng = new Script("Tfng", // Subtag
                                new string[]{ "Tifinagh", "Berber" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Tglg
        /// <summary>
        /// Tagalog
        /// Baybayin
        /// Alibata
        /// </summary>
        public static Script Tglg { get { return _Tglg; } }
        private static Script _Tglg = new Script("Tglg", // Subtag
                                new string[]{ "Tagalog", "Baybayin", "Alibata" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Thaa
        /// <summary>
        /// Thaana
        /// </summary>
        public static Script Thaa { get { return _Thaa; } }
        private static Script _Thaa = new Script("Thaa", // Subtag
                                new string[]{ "Thaana" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Thai
        /// <summary>
        /// Thai
        /// </summary>
        public static Script Thai { get { return _Thai; } }
        private static Script _Thai = new Script("Thai", // Subtag
                                new string[]{ "Thai" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Tibt
        /// <summary>
        /// Tibetan
        /// </summary>
        public static Script Tibt { get { return _Tibt; } }
        private static Script _Tibt = new Script("Tibt", // Subtag
                                new string[]{ "Tibetan" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Tirh
        /// <summary>
        /// Tirhuta
        /// </summary>
        public static Script Tirh { get { return _Tirh; } }
        private static Script _Tirh = new Script("Tirh", // Subtag
                                new string[]{ "Tirhuta" }, // Descriptions
                                new DateTime(2011, 8, 16 ), // Added
                                null); // Comments

        #endregion

        #region Tnsa
        /// <summary>
        /// Tangsa
        /// </summary>
        public static Script Tnsa { get { return _Tnsa; } }
        private static Script _Tnsa = new Script("Tnsa", // Subtag
                                new string[]{ "Tangsa" }, // Descriptions
                                new DateTime(2021, 3, 5 ), // Added
                                null); // Comments

        #endregion

        #region Toto
        /// <summary>
        /// Toto
        /// </summary>
        public static Script Toto { get { return _Toto; } }
        private static Script _Toto = new Script("Toto", // Subtag
                                new string[]{ "Toto" }, // Descriptions
                                new DateTime(2020, 5, 12 ), // Added
                                null); // Comments

        #endregion

        #region Ugar
        /// <summary>
        /// Ugaritic
        /// </summary>
        public static Script Ugar { get { return _Ugar; } }
        private static Script _Ugar = new Script("Ugar", // Subtag
                                new string[]{ "Ugaritic" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Vaii
        /// <summary>
        /// Vai
        /// </summary>
        public static Script Vaii { get { return _Vaii; } }
        private static Script _Vaii = new Script("Vaii", // Subtag
                                new string[]{ "Vai" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Visp
        /// <summary>
        /// Visible Speech
        /// </summary>
        public static Script Visp { get { return _Visp; } }
        private static Script _Visp = new Script("Visp", // Subtag
                                new string[]{ "Visible Speech" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Vith
        /// <summary>
        /// Vithkuqi
        /// </summary>
        public static Script Vith { get { return _Vith; } }
        private static Script _Vith = new Script("Vith", // Subtag
                                new string[]{ "Vithkuqi" }, // Descriptions
                                new DateTime(2021, 3, 5 ), // Added
                                null); // Comments

        #endregion

        #region Wara
        /// <summary>
        /// Warang Citi
        /// Varang Kshiti
        /// </summary>
        public static Script Wara { get { return _Wara; } }
        private static Script _Wara = new Script("Wara", // Subtag
                                new string[]{ "Warang Citi", "Varang Kshiti" }, // Descriptions
                                new DateTime(2009, 12, 9 ), // Added
                                null); // Comments

        #endregion

        #region Wcho
        /// <summary>
        /// Wancho
        /// </summary>
        public static Script Wcho { get { return _Wcho; } }
        private static Script _Wcho = new Script("Wcho", // Subtag
                                new string[]{ "Wancho" }, // Descriptions
                                new DateTime(2017, 8, 13 ), // Added
                                null); // Comments

        #endregion

        #region Wole
        /// <summary>
        /// Woleai
        /// </summary>
        public static Script Wole { get { return _Wole; } }
        private static Script _Wole = new Script("Wole", // Subtag
                                new string[]{ "Woleai" }, // Descriptions
                                new DateTime(2011, 1, 7 ), // Added
                                null); // Comments

        #endregion

        #region Xpeo
        /// <summary>
        /// Old Persian
        /// </summary>
        public static Script Xpeo { get { return _Xpeo; } }
        private static Script _Xpeo = new Script("Xpeo", // Subtag
                                new string[]{ "Old Persian" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Xsux
        /// <summary>
        /// Sumero-Akkadian cuneiform
        /// </summary>
        public static Script Xsux { get { return _Xsux; } }
        private static Script _Xsux = new Script("Xsux", // Subtag
                                new string[]{ "Sumero-Akkadian cuneiform" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Yezi
        /// <summary>
        /// Yezidi
        /// </summary>
        public static Script Yezi { get { return _Yezi; } }
        private static Script _Yezi = new Script("Yezi", // Subtag
                                new string[]{ "Yezidi" }, // Descriptions
                                new DateTime(2019, 9, 11 ), // Added
                                null); // Comments

        #endregion

        #region Yiii
        /// <summary>
        /// Yi
        /// </summary>
        public static Script Yiii { get { return _Yiii; } }
        private static Script _Yiii = new Script("Yiii", // Subtag
                                new string[]{ "Yi" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Zanb
        /// <summary>
        /// Zanabazar Square
        /// Zanabazarin Dörböljin Useg
        /// Xewtee Dörböljin Bicig
        /// Horizontal Square Script
        /// </summary>
        public static Script Zanb { get { return _Zanb; } }
        private static Script _Zanb = new Script("Zanb", // Subtag
                                new string[]{ "Zanabazar Square", "Zanabazarin Dörböljin Useg", "Xewtee Dörböljin Bicig", "Horizontal Square Script" }, // Descriptions
                                new DateTime(2017, 1, 13 ), // Added
                                null); // Comments

        #endregion

        #region Zinh
        /// <summary>
        /// Code for inherited script
        /// </summary>
        /// <remarks>Not intended for use as a language subtag</remarks>
        public static Script Zinh { get { return _Zinh; } }
        private static Script _Zinh = new Script("Zinh", // Subtag
                                new string[]{ "Code for inherited script" }, // Descriptions
                                new DateTime(2009, 4, 3 ), // Added
                                "Not intended for use as a language subtag"); // Comments

        #endregion

        #region Zmth
        /// <summary>
        /// Mathematical notation
        /// </summary>
        public static Script Zmth { get { return _Zmth; } }
        private static Script _Zmth = new Script("Zmth", // Subtag
                                new string[]{ "Mathematical notation" }, // Descriptions
                                new DateTime(2007, 12, 5 ), // Added
                                null); // Comments

        #endregion

        #region Zsye
        /// <summary>
        /// Symbols (Emoji variant)
        /// </summary>
        public static Script Zsye { get { return _Zsye; } }
        private static Script _Zsye = new Script("Zsye", // Subtag
                                new string[]{ "Symbols (Emoji variant)" }, // Descriptions
                                new DateTime(2016, 1, 4 ), // Added
                                null); // Comments

        #endregion

        #region Zsym
        /// <summary>
        /// Symbols
        /// </summary>
        public static Script Zsym { get { return _Zsym; } }
        private static Script _Zsym = new Script("Zsym", // Subtag
                                new string[]{ "Symbols" }, // Descriptions
                                new DateTime(2007, 12, 5 ), // Added
                                null); // Comments

        #endregion

        #region Zxxx
        /// <summary>
        /// Code for unwritten documents
        /// </summary>
        public static Script Zxxx { get { return _Zxxx; } }
        private static Script _Zxxx = new Script("Zxxx", // Subtag
                                new string[]{ "Code for unwritten documents" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Zyyy
        /// <summary>
        /// Code for undetermined script
        /// </summary>
        public static Script Zyyy { get { return _Zyyy; } }
        private static Script _Zyyy = new Script("Zyyy", // Subtag
                                new string[]{ "Code for undetermined script" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion

        #region Zzzz
        /// <summary>
        /// Code for uncoded script
        /// </summary>
        public static Script Zzzz { get { return _Zzzz; } }
        private static Script _Zzzz = new Script("Zzzz", // Subtag
                                new string[]{ "Code for uncoded script" }, // Descriptions
                                new DateTime(2005, 10, 16 ), // Added
                                null); // Comments

        #endregion


        #region Script Collection
        private static object scriptsLock = new object();
        private static Collection<Script> scripts = null;
        public static ReadOnlyCollection<Script> Scripts
        {
            get
            {
                if(scripts == null) 
                {
                    lock(scriptsLock) 
                    {
                        if(scripts == null) 
                        {
                            scripts = new Collection<Script>();
                            scripts.Add(Adlm);
                            scripts.Add(Afak);
                            scripts.Add(Aghb);
                            scripts.Add(Ahom);
                            scripts.Add(Arab);
                            scripts.Add(Aran);
                            scripts.Add(Armi);
                            scripts.Add(Armn);
                            scripts.Add(Avst);
                            scripts.Add(Bali);
                            scripts.Add(Bamu);
                            scripts.Add(Bass);
                            scripts.Add(Batk);
                            scripts.Add(Beng);
                            scripts.Add(Bhks);
                            scripts.Add(Blis);
                            scripts.Add(Bopo);
                            scripts.Add(Brah);
                            scripts.Add(Brai);
                            scripts.Add(Bugi);
                            scripts.Add(Buhd);
                            scripts.Add(Cakm);
                            scripts.Add(Cans);
                            scripts.Add(Cari);
                            scripts.Add(Cham);
                            scripts.Add(Cher);
                            scripts.Add(Chrs);
                            scripts.Add(Cirt);
                            scripts.Add(Copt);
                            scripts.Add(Cpmn);
                            scripts.Add(Cprt);
                            scripts.Add(Cyrl);
                            scripts.Add(Cyrs);
                            scripts.Add(Deva);
                            scripts.Add(Diak);
                            scripts.Add(Dogr);
                            scripts.Add(Dsrt);
                            scripts.Add(Dupl);
                            scripts.Add(Egyd);
                            scripts.Add(Egyh);
                            scripts.Add(Egyp);
                            scripts.Add(Elba);
                            scripts.Add(Elym);
                            scripts.Add(Ethi);
                            scripts.Add(Geok);
                            scripts.Add(Geor);
                            scripts.Add(Glag);
                            scripts.Add(Gong);
                            scripts.Add(Gonm);
                            scripts.Add(Goth);
                            scripts.Add(Gran);
                            scripts.Add(Grek);
                            scripts.Add(Gujr);
                            scripts.Add(Guru);
                            scripts.Add(Hanb);
                            scripts.Add(Hang);
                            scripts.Add(Hani);
                            scripts.Add(Hano);
                            scripts.Add(Hans);
                            scripts.Add(Hant);
                            scripts.Add(Hatr);
                            scripts.Add(Hebr);
                            scripts.Add(Hira);
                            scripts.Add(Hluw);
                            scripts.Add(Hmng);
                            scripts.Add(Hmnp);
                            scripts.Add(Hrkt);
                            scripts.Add(Hung);
                            scripts.Add(Inds);
                            scripts.Add(Ital);
                            scripts.Add(Jamo);
                            scripts.Add(Java);
                            scripts.Add(Jpan);
                            scripts.Add(Jurc);
                            scripts.Add(Kali);
                            scripts.Add(Kana);
                            scripts.Add(Kawi);
                            scripts.Add(Khar);
                            scripts.Add(Khmr);
                            scripts.Add(Khoj);
                            scripts.Add(Kitl);
                            scripts.Add(Kits);
                            scripts.Add(Knda);
                            scripts.Add(Kore);
                            scripts.Add(Kpel);
                            scripts.Add(Kthi);
                            scripts.Add(Lana);
                            scripts.Add(Laoo);
                            scripts.Add(Latf);
                            scripts.Add(Latg);
                            scripts.Add(Latn);
                            scripts.Add(Leke);
                            scripts.Add(Lepc);
                            scripts.Add(Limb);
                            scripts.Add(Lina);
                            scripts.Add(Linb);
                            scripts.Add(Lisu);
                            scripts.Add(Loma);
                            scripts.Add(Lyci);
                            scripts.Add(Lydi);
                            scripts.Add(Mahj);
                            scripts.Add(Maka);
                            scripts.Add(Mand);
                            scripts.Add(Mani);
                            scripts.Add(Marc);
                            scripts.Add(Maya);
                            scripts.Add(Medf);
                            scripts.Add(Mend);
                            scripts.Add(Merc);
                            scripts.Add(Mero);
                            scripts.Add(Mlym);
                            scripts.Add(Modi);
                            scripts.Add(Mong);
                            scripts.Add(Moon);
                            scripts.Add(Mroo);
                            scripts.Add(Mtei);
                            scripts.Add(Mult);
                            scripts.Add(Mymr);
                            scripts.Add(Nagm);
                            scripts.Add(Nand);
                            scripts.Add(Narb);
                            scripts.Add(Nbat);
                            scripts.Add(Newa);
                            scripts.Add(Nkdb);
                            scripts.Add(Nkgb);
                            scripts.Add(Nkoo);
                            scripts.Add(Nshu);
                            scripts.Add(Ogam);
                            scripts.Add(Olck);
                            scripts.Add(Orkh);
                            scripts.Add(Orya);
                            scripts.Add(Osge);
                            scripts.Add(Osma);
                            scripts.Add(Ougr);
                            scripts.Add(Palm);
                            scripts.Add(Pauc);
                            scripts.Add(Pcun);
                            scripts.Add(Pelm);
                            scripts.Add(Perm);
                            scripts.Add(Phag);
                            scripts.Add(Phli);
                            scripts.Add(Phlp);
                            scripts.Add(Phlv);
                            scripts.Add(Phnx);
                            scripts.Add(Piqd);
                            scripts.Add(Plrd);
                            scripts.Add(Prti);
                            scripts.Add(Psin);
                            scripts.Add(Qaaa);
                            scripts.Add(Qaab);
                            scripts.Add(Qaac);
                            scripts.Add(Qaad);
                            scripts.Add(Qaae);
                            scripts.Add(Qaaf);
                            scripts.Add(Qaag);
                            scripts.Add(Qaah);
                            scripts.Add(Qaai);
                            scripts.Add(Qaaj);
                            scripts.Add(Qaak);
                            scripts.Add(Qaal);
                            scripts.Add(Qaam);
                            scripts.Add(Qaan);
                            scripts.Add(Qaao);
                            scripts.Add(Qaap);
                            scripts.Add(Qaaq);
                            scripts.Add(Qaar);
                            scripts.Add(Qaas);
                            scripts.Add(Qaat);
                            scripts.Add(Qaau);
                            scripts.Add(Qaav);
                            scripts.Add(Qaaw);
                            scripts.Add(Qaax);
                            scripts.Add(Qaay);
                            scripts.Add(Qaaz);
                            scripts.Add(Qaba);
                            scripts.Add(Qabb);
                            scripts.Add(Qabc);
                            scripts.Add(Qabd);
                            scripts.Add(Qabe);
                            scripts.Add(Qabf);
                            scripts.Add(Qabg);
                            scripts.Add(Qabh);
                            scripts.Add(Qabi);
                            scripts.Add(Qabj);
                            scripts.Add(Qabk);
                            scripts.Add(Qabl);
                            scripts.Add(Qabm);
                            scripts.Add(Qabn);
                            scripts.Add(Qabo);
                            scripts.Add(Qabp);
                            scripts.Add(Qabq);
                            scripts.Add(Qabr);
                            scripts.Add(Qabs);
                            scripts.Add(Qabt);
                            scripts.Add(Qabu);
                            scripts.Add(Qabv);
                            scripts.Add(Qabw);
                            scripts.Add(Qabx);
                            scripts.Add(Ranj);
                            scripts.Add(Rjng);
                            scripts.Add(Rohg);
                            scripts.Add(Roro);
                            scripts.Add(Runr);
                            scripts.Add(Samr);
                            scripts.Add(Sara);
                            scripts.Add(Sarb);
                            scripts.Add(Saur);
                            scripts.Add(Sgnw);
                            scripts.Add(Shaw);
                            scripts.Add(Shrd);
                            scripts.Add(Shui);
                            scripts.Add(Sidd);
                            scripts.Add(Sind);
                            scripts.Add(Sinh);
                            scripts.Add(Sogd);
                            scripts.Add(Sogo);
                            scripts.Add(Sora);
                            scripts.Add(Soyo);
                            scripts.Add(Sund);
                            scripts.Add(Sunu);
                            scripts.Add(Sylo);
                            scripts.Add(Syrc);
                            scripts.Add(Syre);
                            scripts.Add(Syrj);
                            scripts.Add(Syrn);
                            scripts.Add(Tagb);
                            scripts.Add(Takr);
                            scripts.Add(Tale);
                            scripts.Add(Talu);
                            scripts.Add(Taml);
                            scripts.Add(Tang);
                            scripts.Add(Tavt);
                            scripts.Add(Telu);
                            scripts.Add(Teng);
                            scripts.Add(Tfng);
                            scripts.Add(Tglg);
                            scripts.Add(Thaa);
                            scripts.Add(Thai);
                            scripts.Add(Tibt);
                            scripts.Add(Tirh);
                            scripts.Add(Tnsa);
                            scripts.Add(Toto);
                            scripts.Add(Ugar);
                            scripts.Add(Vaii);
                            scripts.Add(Visp);
                            scripts.Add(Vith);
                            scripts.Add(Wara);
                            scripts.Add(Wcho);
                            scripts.Add(Wole);
                            scripts.Add(Xpeo);
                            scripts.Add(Xsux);
                            scripts.Add(Yezi);
                            scripts.Add(Yiii);
                            scripts.Add(Zanb);
                            scripts.Add(Zinh);
                            scripts.Add(Zmth);
                            scripts.Add(Zsye);
                            scripts.Add(Zsym);
                            scripts.Add(Zxxx);
                            scripts.Add(Zyyy);
                            scripts.Add(Zzzz);
                        }
                    }
                }
                return new ReadOnlyCollection<Script>(scripts);
            }

        }
        #endregion
        #endregion


    }
}
