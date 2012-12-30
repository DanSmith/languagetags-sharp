using System;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;

namespace Algenta.Globalization.LanguageTags 
{
    
//region: Type Subtag Description Added (Deprecated) (Comments) (Preferred-Value) 

    public partial class Region 
    {

        private Region(string subtag, 
            string[] descriptions,
            DateTime added,
            DateTime? deprecated,
            string perferredValue, 
            string comment)
        {
            this.Subtag = subtag;
            this.descriptions = new ReadOnlyCollection<string>(descriptions);
            this.Added = added;
            this.Comments = comment;
            this.Deprecated = deprecated;
            this.PreferredValue = perferredValue;
        }

        public string Subtag { get; private set; }

        private ReadOnlyCollection<string> descriptions = null;
        public ReadOnlyCollection<string> Descriptions { get { return descriptions; } }
                
        public DateTime Added { get; private set; }
        public DateTime? Deprecated { get; private set; }
        public string PreferredValue { get; private set; }
        public string Comments { get; private set; }

        #region static Regions
        #region 001
        /// <summary>
        /// World
        /// </summary>
        public static Region M49_001 { get { return _M49_001; } }
        private static Region _M49_001 = new Region("001", // Subtag
                                new string[]{ "World" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 002
        /// <summary>
        /// Africa
        /// </summary>
        public static Region M49_002 { get { return _M49_002; } }
        private static Region _M49_002 = new Region("002", // Subtag
                                new string[]{ "Africa" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 003
        /// <summary>
        /// North America
        /// </summary>
        /// <remarks>Includes Northern America (021), Caribbean (029), and CentralAmerica (013); see also 021</remarks>
        public static Region M49_003 { get { return _M49_003; } }
        private static Region _M49_003 = new Region("003", // Subtag
                                new string[]{ "North America" }, // Description
                                new DateTime(2010, 8, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                "Includes Northern America (021), Caribbean (029), and CentralAmerica (013); see also 021"); // Comments

        #endregion

        #region 005
        /// <summary>
        /// South America
        /// </summary>
        public static Region M49_005 { get { return _M49_005; } }
        private static Region _M49_005 = new Region("005", // Subtag
                                new string[]{ "South America" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 009
        /// <summary>
        /// Oceania
        /// </summary>
        public static Region M49_009 { get { return _M49_009; } }
        private static Region _M49_009 = new Region("009", // Subtag
                                new string[]{ "Oceania" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 011
        /// <summary>
        /// Western Africa
        /// </summary>
        public static Region M49_011 { get { return _M49_011; } }
        private static Region _M49_011 = new Region("011", // Subtag
                                new string[]{ "Western Africa" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 013
        /// <summary>
        /// Central America
        /// </summary>
        public static Region M49_013 { get { return _M49_013; } }
        private static Region _M49_013 = new Region("013", // Subtag
                                new string[]{ "Central America" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 014
        /// <summary>
        /// Eastern Africa
        /// </summary>
        public static Region M49_014 { get { return _M49_014; } }
        private static Region _M49_014 = new Region("014", // Subtag
                                new string[]{ "Eastern Africa" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 015
        /// <summary>
        /// Northern Africa
        /// </summary>
        public static Region M49_015 { get { return _M49_015; } }
        private static Region _M49_015 = new Region("015", // Subtag
                                new string[]{ "Northern Africa" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 017
        /// <summary>
        /// Middle Africa
        /// </summary>
        public static Region M49_017 { get { return _M49_017; } }
        private static Region _M49_017 = new Region("017", // Subtag
                                new string[]{ "Middle Africa" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 018
        /// <summary>
        /// Southern Africa
        /// </summary>
        public static Region M49_018 { get { return _M49_018; } }
        private static Region _M49_018 = new Region("018", // Subtag
                                new string[]{ "Southern Africa" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 019
        /// <summary>
        /// Americas
        /// </summary>
        public static Region M49_019 { get { return _M49_019; } }
        private static Region _M49_019 = new Region("019", // Subtag
                                new string[]{ "Americas" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 021
        /// <summary>
        /// Northern America
        /// </summary>
        /// <remarks>Does not include Caribbean (029) or Central America (013); seealso 003</remarks>
        public static Region M49_021 { get { return _M49_021; } }
        private static Region _M49_021 = new Region("021", // Subtag
                                new string[]{ "Northern America" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                "Does not include Caribbean (029) or Central America (013); seealso 003"); // Comments

        #endregion

        #region 029
        /// <summary>
        /// Caribbean
        /// </summary>
        public static Region M49_029 { get { return _M49_029; } }
        private static Region _M49_029 = new Region("029", // Subtag
                                new string[]{ "Caribbean" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 030
        /// <summary>
        /// Eastern Asia
        /// </summary>
        public static Region M49_030 { get { return _M49_030; } }
        private static Region _M49_030 = new Region("030", // Subtag
                                new string[]{ "Eastern Asia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 034
        /// <summary>
        /// Southern Asia
        /// </summary>
        public static Region M49_034 { get { return _M49_034; } }
        private static Region _M49_034 = new Region("034", // Subtag
                                new string[]{ "Southern Asia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 035
        /// <summary>
        /// South-Eastern Asia
        /// </summary>
        public static Region M49_035 { get { return _M49_035; } }
        private static Region _M49_035 = new Region("035", // Subtag
                                new string[]{ "South-Eastern Asia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 039
        /// <summary>
        /// Southern Europe
        /// </summary>
        public static Region M49_039 { get { return _M49_039; } }
        private static Region _M49_039 = new Region("039", // Subtag
                                new string[]{ "Southern Europe" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 053
        /// <summary>
        /// Australia and New Zealand
        /// </summary>
        public static Region M49_053 { get { return _M49_053; } }
        private static Region _M49_053 = new Region("053", // Subtag
                                new string[]{ "Australia and New Zealand" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 054
        /// <summary>
        /// Melanesia
        /// </summary>
        public static Region M49_054 { get { return _M49_054; } }
        private static Region _M49_054 = new Region("054", // Subtag
                                new string[]{ "Melanesia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 057
        /// <summary>
        /// Micronesia
        /// </summary>
        public static Region M49_057 { get { return _M49_057; } }
        private static Region _M49_057 = new Region("057", // Subtag
                                new string[]{ "Micronesia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 061
        /// <summary>
        /// Polynesia
        /// </summary>
        public static Region M49_061 { get { return _M49_061; } }
        private static Region _M49_061 = new Region("061", // Subtag
                                new string[]{ "Polynesia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 142
        /// <summary>
        /// Asia
        /// </summary>
        public static Region M49_142 { get { return _M49_142; } }
        private static Region _M49_142 = new Region("142", // Subtag
                                new string[]{ "Asia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 143
        /// <summary>
        /// Central Asia
        /// </summary>
        public static Region M49_143 { get { return _M49_143; } }
        private static Region _M49_143 = new Region("143", // Subtag
                                new string[]{ "Central Asia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 145
        /// <summary>
        /// Western Asia
        /// </summary>
        public static Region M49_145 { get { return _M49_145; } }
        private static Region _M49_145 = new Region("145", // Subtag
                                new string[]{ "Western Asia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 150
        /// <summary>
        /// Europe
        /// </summary>
        public static Region M49_150 { get { return _M49_150; } }
        private static Region _M49_150 = new Region("150", // Subtag
                                new string[]{ "Europe" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 151
        /// <summary>
        /// Eastern Europe
        /// </summary>
        public static Region M49_151 { get { return _M49_151; } }
        private static Region _M49_151 = new Region("151", // Subtag
                                new string[]{ "Eastern Europe" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 154
        /// <summary>
        /// Northern Europe
        /// </summary>
        public static Region M49_154 { get { return _M49_154; } }
        private static Region _M49_154 = new Region("154", // Subtag
                                new string[]{ "Northern Europe" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 155
        /// <summary>
        /// Western Europe
        /// </summary>
        public static Region M49_155 { get { return _M49_155; } }
        private static Region _M49_155 = new Region("155", // Subtag
                                new string[]{ "Western Europe" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region 419
        /// <summary>
        /// Latin America and the Caribbean
        /// </summary>
        public static Region M49_419 { get { return _M49_419; } }
        private static Region _M49_419 = new Region("419", // Subtag
                                new string[]{ "Latin America and the Caribbean" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AA
        /// <summary>
        /// Private use
        /// </summary>
        public static Region AA { get { return _AA; } }
        private static Region _AA = new Region("AA", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AC
        /// <summary>
        /// Ascension Island
        /// </summary>
        public static Region AC { get { return _AC; } }
        private static Region _AC = new Region("AC", // Subtag
                                new string[]{ "Ascension Island" }, // Description
                                new DateTime(2009, 7, 29 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AD
        /// <summary>
        /// Andorra
        /// </summary>
        public static Region AD { get { return _AD; } }
        private static Region _AD = new Region("AD", // Subtag
                                new string[]{ "Andorra" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AE
        /// <summary>
        /// United Arab Emirates
        /// </summary>
        public static Region AE { get { return _AE; } }
        private static Region _AE = new Region("AE", // Subtag
                                new string[]{ "United Arab Emirates" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AF
        /// <summary>
        /// Afghanistan
        /// </summary>
        public static Region AF { get { return _AF; } }
        private static Region _AF = new Region("AF", // Subtag
                                new string[]{ "Afghanistan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AG
        /// <summary>
        /// Antigua and Barbuda
        /// </summary>
        public static Region AG { get { return _AG; } }
        private static Region _AG = new Region("AG", // Subtag
                                new string[]{ "Antigua and Barbuda" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AI
        /// <summary>
        /// Anguilla
        /// </summary>
        public static Region AI { get { return _AI; } }
        private static Region _AI = new Region("AI", // Subtag
                                new string[]{ "Anguilla" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AL
        /// <summary>
        /// Albania
        /// </summary>
        public static Region AL { get { return _AL; } }
        private static Region _AL = new Region("AL", // Subtag
                                new string[]{ "Albania" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AM
        /// <summary>
        /// Armenia
        /// </summary>
        public static Region AM { get { return _AM; } }
        private static Region _AM = new Region("AM", // Subtag
                                new string[]{ "Armenia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AN
        /// <summary>
        /// Netherlands Antilles
        /// </summary>
        /// <remarks>see BQ, CW, and SX</remarks>
        public static Region AN { get { return _AN; } }
        private static Region _AN = new Region("AN", // Subtag
                                new string[]{ "Netherlands Antilles" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(2011, 1, 7 ), //Deprecated
                                                                null, // PreferredValue
                                "see BQ, CW, and SX"); // Comments

        #endregion

        #region AO
        /// <summary>
        /// Angola
        /// </summary>
        public static Region AO { get { return _AO; } }
        private static Region _AO = new Region("AO", // Subtag
                                new string[]{ "Angola" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AQ
        /// <summary>
        /// Antarctica
        /// </summary>
        public static Region AQ { get { return _AQ; } }
        private static Region _AQ = new Region("AQ", // Subtag
                                new string[]{ "Antarctica" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AR
        /// <summary>
        /// Argentina
        /// </summary>
        public static Region AR { get { return _AR; } }
        private static Region _AR = new Region("AR", // Subtag
                                new string[]{ "Argentina" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AS
        /// <summary>
        /// American Samoa
        /// </summary>
        public static Region AS { get { return _AS; } }
        private static Region _AS = new Region("AS", // Subtag
                                new string[]{ "American Samoa" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AT
        /// <summary>
        /// Austria
        /// </summary>
        public static Region AT { get { return _AT; } }
        private static Region _AT = new Region("AT", // Subtag
                                new string[]{ "Austria" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AU
        /// <summary>
        /// Australia
        /// </summary>
        public static Region AU { get { return _AU; } }
        private static Region _AU = new Region("AU", // Subtag
                                new string[]{ "Australia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AW
        /// <summary>
        /// Aruba
        /// </summary>
        public static Region AW { get { return _AW; } }
        private static Region _AW = new Region("AW", // Subtag
                                new string[]{ "Aruba" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AX
        /// <summary>
        /// Åland Islands
        /// </summary>
        public static Region AX { get { return _AX; } }
        private static Region _AX = new Region("AX", // Subtag
                                new string[]{ "Åland Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region AZ
        /// <summary>
        /// Azerbaijan
        /// </summary>
        public static Region AZ { get { return _AZ; } }
        private static Region _AZ = new Region("AZ", // Subtag
                                new string[]{ "Azerbaijan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BA
        /// <summary>
        /// Bosnia and Herzegovina
        /// </summary>
        public static Region BA { get { return _BA; } }
        private static Region _BA = new Region("BA", // Subtag
                                new string[]{ "Bosnia and Herzegovina" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BB
        /// <summary>
        /// Barbados
        /// </summary>
        public static Region BB { get { return _BB; } }
        private static Region _BB = new Region("BB", // Subtag
                                new string[]{ "Barbados" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BD
        /// <summary>
        /// Bangladesh
        /// </summary>
        public static Region BD { get { return _BD; } }
        private static Region _BD = new Region("BD", // Subtag
                                new string[]{ "Bangladesh" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BE
        /// <summary>
        /// Belgium
        /// </summary>
        public static Region BE { get { return _BE; } }
        private static Region _BE = new Region("BE", // Subtag
                                new string[]{ "Belgium" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BF
        /// <summary>
        /// Burkina Faso
        /// </summary>
        public static Region BF { get { return _BF; } }
        private static Region _BF = new Region("BF", // Subtag
                                new string[]{ "Burkina Faso" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BG
        /// <summary>
        /// Bulgaria
        /// </summary>
        public static Region BG { get { return _BG; } }
        private static Region _BG = new Region("BG", // Subtag
                                new string[]{ "Bulgaria" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BH
        /// <summary>
        /// Bahrain
        /// </summary>
        public static Region BH { get { return _BH; } }
        private static Region _BH = new Region("BH", // Subtag
                                new string[]{ "Bahrain" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BI
        /// <summary>
        /// Burundi
        /// </summary>
        public static Region BI { get { return _BI; } }
        private static Region _BI = new Region("BI", // Subtag
                                new string[]{ "Burundi" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BJ
        /// <summary>
        /// Benin
        /// </summary>
        public static Region BJ { get { return _BJ; } }
        private static Region _BJ = new Region("BJ", // Subtag
                                new string[]{ "Benin" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BL
        /// <summary>
        /// Saint Barthélemy
        /// </summary>
        public static Region BL { get { return _BL; } }
        private static Region _BL = new Region("BL", // Subtag
                                new string[]{ "Saint Barthélemy" }, // Description
                                new DateTime(2007, 11, 2 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BM
        /// <summary>
        /// Bermuda
        /// </summary>
        public static Region BM { get { return _BM; } }
        private static Region _BM = new Region("BM", // Subtag
                                new string[]{ "Bermuda" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BN
        /// <summary>
        /// Brunei Darussalam
        /// </summary>
        public static Region BN { get { return _BN; } }
        private static Region _BN = new Region("BN", // Subtag
                                new string[]{ "Brunei Darussalam" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BO
        /// <summary>
        /// Bolivia
        /// </summary>
        public static Region BO { get { return _BO; } }
        private static Region _BO = new Region("BO", // Subtag
                                new string[]{ "Bolivia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BQ
        /// <summary>
        /// Bonaire, Sint Eustatius and Saba
        /// </summary>
        public static Region BQ { get { return _BQ; } }
        private static Region _BQ = new Region("BQ", // Subtag
                                new string[]{ "Bonaire", " Sint Eustatius and Saba" }, // Description
                                new DateTime(2011, 1, 7 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BR
        /// <summary>
        /// Brazil
        /// </summary>
        public static Region BR { get { return _BR; } }
        private static Region _BR = new Region("BR", // Subtag
                                new string[]{ "Brazil" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BS
        /// <summary>
        /// Bahamas
        /// </summary>
        public static Region BS { get { return _BS; } }
        private static Region _BS = new Region("BS", // Subtag
                                new string[]{ "Bahamas" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BT
        /// <summary>
        /// Bhutan
        /// </summary>
        public static Region BT { get { return _BT; } }
        private static Region _BT = new Region("BT", // Subtag
                                new string[]{ "Bhutan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BU
        /// <summary>
        /// Burma
        /// </summary>
        public static Region BU { get { return _BU; } }
        private static Region _BU = new Region("BU", // Subtag
                                new string[]{ "Burma" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(1989, 12, 5 ), //Deprecated
                                                                "MM", // PreferredValue
                                null); // Comments

        #endregion

        #region BV
        /// <summary>
        /// Bouvet Island
        /// </summary>
        public static Region BV { get { return _BV; } }
        private static Region _BV = new Region("BV", // Subtag
                                new string[]{ "Bouvet Island" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BW
        /// <summary>
        /// Botswana
        /// </summary>
        public static Region BW { get { return _BW; } }
        private static Region _BW = new Region("BW", // Subtag
                                new string[]{ "Botswana" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BY
        /// <summary>
        /// Belarus
        /// </summary>
        public static Region BY { get { return _BY; } }
        private static Region _BY = new Region("BY", // Subtag
                                new string[]{ "Belarus" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region BZ
        /// <summary>
        /// Belize
        /// </summary>
        public static Region BZ { get { return _BZ; } }
        private static Region _BZ = new Region("BZ", // Subtag
                                new string[]{ "Belize" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CA
        /// <summary>
        /// Canada
        /// </summary>
        public static Region CA { get { return _CA; } }
        private static Region _CA = new Region("CA", // Subtag
                                new string[]{ "Canada" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CC
        /// <summary>
        /// Cocos (Keeling) Islands
        /// </summary>
        public static Region CC { get { return _CC; } }
        private static Region _CC = new Region("CC", // Subtag
                                new string[]{ "Cocos (Keeling) Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CD
        /// <summary>
        /// The Democratic Republic of the Congo
        /// </summary>
        public static Region CD { get { return _CD; } }
        private static Region _CD = new Region("CD", // Subtag
                                new string[]{ "The Democratic Republic of the Congo" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CF
        /// <summary>
        /// Central African Republic
        /// </summary>
        public static Region CF { get { return _CF; } }
        private static Region _CF = new Region("CF", // Subtag
                                new string[]{ "Central African Republic" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CG
        /// <summary>
        /// Congo
        /// </summary>
        public static Region CG { get { return _CG; } }
        private static Region _CG = new Region("CG", // Subtag
                                new string[]{ "Congo" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CH
        /// <summary>
        /// Switzerland
        /// </summary>
        public static Region CH { get { return _CH; } }
        private static Region _CH = new Region("CH", // Subtag
                                new string[]{ "Switzerland" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CI
        /// <summary>
        /// Côte d'Ivoire
        /// </summary>
        public static Region CI { get { return _CI; } }
        private static Region _CI = new Region("CI", // Subtag
                                new string[]{ "Côte d'Ivoire" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CK
        /// <summary>
        /// Cook Islands
        /// </summary>
        public static Region CK { get { return _CK; } }
        private static Region _CK = new Region("CK", // Subtag
                                new string[]{ "Cook Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CL
        /// <summary>
        /// Chile
        /// </summary>
        public static Region CL { get { return _CL; } }
        private static Region _CL = new Region("CL", // Subtag
                                new string[]{ "Chile" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CM
        /// <summary>
        /// Cameroon
        /// </summary>
        public static Region CM { get { return _CM; } }
        private static Region _CM = new Region("CM", // Subtag
                                new string[]{ "Cameroon" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CN
        /// <summary>
        /// China
        /// </summary>
        public static Region CN { get { return _CN; } }
        private static Region _CN = new Region("CN", // Subtag
                                new string[]{ "China" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CO
        /// <summary>
        /// Colombia
        /// </summary>
        public static Region CO { get { return _CO; } }
        private static Region _CO = new Region("CO", // Subtag
                                new string[]{ "Colombia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CP
        /// <summary>
        /// Clipperton Island
        /// </summary>
        public static Region CP { get { return _CP; } }
        private static Region _CP = new Region("CP", // Subtag
                                new string[]{ "Clipperton Island" }, // Description
                                new DateTime(2009, 7, 29 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CR
        /// <summary>
        /// Costa Rica
        /// </summary>
        public static Region CR { get { return _CR; } }
        private static Region _CR = new Region("CR", // Subtag
                                new string[]{ "Costa Rica" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CS
        /// <summary>
        /// Serbia and Montenegro
        /// </summary>
        /// <remarks>see RS for Serbia or ME for Montenegro</remarks>
        public static Region CS { get { return _CS; } }
        private static Region _CS = new Region("CS", // Subtag
                                new string[]{ "Serbia and Montenegro" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(2006, 10, 5 ), //Deprecated
                                                                null, // PreferredValue
                                "see RS for Serbia or ME for Montenegro"); // Comments

        #endregion

        #region CU
        /// <summary>
        /// Cuba
        /// </summary>
        public static Region CU { get { return _CU; } }
        private static Region _CU = new Region("CU", // Subtag
                                new string[]{ "Cuba" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CV
        /// <summary>
        /// Cape Verde
        /// </summary>
        public static Region CV { get { return _CV; } }
        private static Region _CV = new Region("CV", // Subtag
                                new string[]{ "Cape Verde" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CW
        /// <summary>
        /// Curaçao
        /// </summary>
        public static Region CW { get { return _CW; } }
        private static Region _CW = new Region("CW", // Subtag
                                new string[]{ "Curaçao" }, // Description
                                new DateTime(2011, 1, 7 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CX
        /// <summary>
        /// Christmas Island
        /// </summary>
        public static Region CX { get { return _CX; } }
        private static Region _CX = new Region("CX", // Subtag
                                new string[]{ "Christmas Island" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CY
        /// <summary>
        /// Cyprus
        /// </summary>
        public static Region CY { get { return _CY; } }
        private static Region _CY = new Region("CY", // Subtag
                                new string[]{ "Cyprus" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region CZ
        /// <summary>
        /// Czech Republic
        /// </summary>
        public static Region CZ { get { return _CZ; } }
        private static Region _CZ = new Region("CZ", // Subtag
                                new string[]{ "Czech Republic" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region DD
        /// <summary>
        /// German Democratic Republic
        /// </summary>
        public static Region DD { get { return _DD; } }
        private static Region _DD = new Region("DD", // Subtag
                                new string[]{ "German Democratic Republic" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(1990, 10, 30 ), //Deprecated
                                                                "DE", // PreferredValue
                                null); // Comments

        #endregion

        #region DE
        /// <summary>
        /// Germany
        /// </summary>
        public static Region DE { get { return _DE; } }
        private static Region _DE = new Region("DE", // Subtag
                                new string[]{ "Germany" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region DG
        /// <summary>
        /// Diego Garcia
        /// </summary>
        public static Region DG { get { return _DG; } }
        private static Region _DG = new Region("DG", // Subtag
                                new string[]{ "Diego Garcia" }, // Description
                                new DateTime(2009, 7, 29 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region DJ
        /// <summary>
        /// Djibouti
        /// </summary>
        public static Region DJ { get { return _DJ; } }
        private static Region _DJ = new Region("DJ", // Subtag
                                new string[]{ "Djibouti" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region DK
        /// <summary>
        /// Denmark
        /// </summary>
        public static Region DK { get { return _DK; } }
        private static Region _DK = new Region("DK", // Subtag
                                new string[]{ "Denmark" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region DM
        /// <summary>
        /// Dominica
        /// </summary>
        public static Region DM { get { return _DM; } }
        private static Region _DM = new Region("DM", // Subtag
                                new string[]{ "Dominica" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region DO
        /// <summary>
        /// Dominican Republic
        /// </summary>
        public static Region DO { get { return _DO; } }
        private static Region _DO = new Region("DO", // Subtag
                                new string[]{ "Dominican Republic" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region DZ
        /// <summary>
        /// Algeria
        /// </summary>
        public static Region DZ { get { return _DZ; } }
        private static Region _DZ = new Region("DZ", // Subtag
                                new string[]{ "Algeria" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region EA
        /// <summary>
        /// Ceuta, Melilla
        /// </summary>
        public static Region EA { get { return _EA; } }
        private static Region _EA = new Region("EA", // Subtag
                                new string[]{ "Ceuta", " Melilla" }, // Description
                                new DateTime(2009, 7, 29 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region EC
        /// <summary>
        /// Ecuador
        /// </summary>
        public static Region EC { get { return _EC; } }
        private static Region _EC = new Region("EC", // Subtag
                                new string[]{ "Ecuador" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region EE
        /// <summary>
        /// Estonia
        /// </summary>
        public static Region EE { get { return _EE; } }
        private static Region _EE = new Region("EE", // Subtag
                                new string[]{ "Estonia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region EG
        /// <summary>
        /// Egypt
        /// </summary>
        public static Region EG { get { return _EG; } }
        private static Region _EG = new Region("EG", // Subtag
                                new string[]{ "Egypt" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region EH
        /// <summary>
        /// Western Sahara
        /// </summary>
        public static Region EH { get { return _EH; } }
        private static Region _EH = new Region("EH", // Subtag
                                new string[]{ "Western Sahara" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region ER
        /// <summary>
        /// Eritrea
        /// </summary>
        public static Region ER { get { return _ER; } }
        private static Region _ER = new Region("ER", // Subtag
                                new string[]{ "Eritrea" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region ES
        /// <summary>
        /// Spain
        /// </summary>
        public static Region ES { get { return _ES; } }
        private static Region _ES = new Region("ES", // Subtag
                                new string[]{ "Spain" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region ET
        /// <summary>
        /// Ethiopia
        /// </summary>
        public static Region ET { get { return _ET; } }
        private static Region _ET = new Region("ET", // Subtag
                                new string[]{ "Ethiopia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region EU
        /// <summary>
        /// European Union
        /// </summary>
        public static Region EU { get { return _EU; } }
        private static Region _EU = new Region("EU", // Subtag
                                new string[]{ "European Union" }, // Description
                                new DateTime(2009, 7, 29 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region FI
        /// <summary>
        /// Finland
        /// </summary>
        public static Region FI { get { return _FI; } }
        private static Region _FI = new Region("FI", // Subtag
                                new string[]{ "Finland" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region FJ
        /// <summary>
        /// Fiji
        /// </summary>
        public static Region FJ { get { return _FJ; } }
        private static Region _FJ = new Region("FJ", // Subtag
                                new string[]{ "Fiji" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region FK
        /// <summary>
        /// Falkland Islands (Malvinas)
        /// </summary>
        public static Region FK { get { return _FK; } }
        private static Region _FK = new Region("FK", // Subtag
                                new string[]{ "Falkland Islands (Malvinas)" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region FM
        /// <summary>
        /// Federated States of Micronesia
        /// </summary>
        public static Region FM { get { return _FM; } }
        private static Region _FM = new Region("FM", // Subtag
                                new string[]{ "Federated States of Micronesia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region FO
        /// <summary>
        /// Faroe Islands
        /// </summary>
        public static Region FO { get { return _FO; } }
        private static Region _FO = new Region("FO", // Subtag
                                new string[]{ "Faroe Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region FR
        /// <summary>
        /// France
        /// </summary>
        public static Region FR { get { return _FR; } }
        private static Region _FR = new Region("FR", // Subtag
                                new string[]{ "France" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region FX
        /// <summary>
        /// Metropolitan France
        /// </summary>
        public static Region FX { get { return _FX; } }
        private static Region _FX = new Region("FX", // Subtag
                                new string[]{ "Metropolitan France" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(1997, 7, 14 ), //Deprecated
                                                                "FR", // PreferredValue
                                null); // Comments

        #endregion

        #region GA
        /// <summary>
        /// Gabon
        /// </summary>
        public static Region GA { get { return _GA; } }
        private static Region _GA = new Region("GA", // Subtag
                                new string[]{ "Gabon" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GB
        /// <summary>
        /// United Kingdom
        /// </summary>
        /// <remarks>as of 2006-03-29 GB no longer includes the Channel Islands andIsle of Man; see GG, JE, IM</remarks>
        public static Region GB { get { return _GB; } }
        private static Region _GB = new Region("GB", // Subtag
                                new string[]{ "United Kingdom" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                "as of 2006-03-29 GB no longer includes the Channel Islands andIsle of Man; see GG, JE, IM"); // Comments

        #endregion

        #region GD
        /// <summary>
        /// Grenada
        /// </summary>
        public static Region GD { get { return _GD; } }
        private static Region _GD = new Region("GD", // Subtag
                                new string[]{ "Grenada" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GE
        /// <summary>
        /// Georgia
        /// </summary>
        public static Region GE { get { return _GE; } }
        private static Region _GE = new Region("GE", // Subtag
                                new string[]{ "Georgia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GF
        /// <summary>
        /// French Guiana
        /// </summary>
        public static Region GF { get { return _GF; } }
        private static Region _GF = new Region("GF", // Subtag
                                new string[]{ "French Guiana" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GG
        /// <summary>
        /// Guernsey
        /// </summary>
        public static Region GG { get { return _GG; } }
        private static Region _GG = new Region("GG", // Subtag
                                new string[]{ "Guernsey" }, // Description
                                new DateTime(2006, 3, 29 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GH
        /// <summary>
        /// Ghana
        /// </summary>
        public static Region GH { get { return _GH; } }
        private static Region _GH = new Region("GH", // Subtag
                                new string[]{ "Ghana" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GI
        /// <summary>
        /// Gibraltar
        /// </summary>
        public static Region GI { get { return _GI; } }
        private static Region _GI = new Region("GI", // Subtag
                                new string[]{ "Gibraltar" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GL
        /// <summary>
        /// Greenland
        /// </summary>
        public static Region GL { get { return _GL; } }
        private static Region _GL = new Region("GL", // Subtag
                                new string[]{ "Greenland" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GM
        /// <summary>
        /// Gambia
        /// </summary>
        public static Region GM { get { return _GM; } }
        private static Region _GM = new Region("GM", // Subtag
                                new string[]{ "Gambia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GN
        /// <summary>
        /// Guinea
        /// </summary>
        public static Region GN { get { return _GN; } }
        private static Region _GN = new Region("GN", // Subtag
                                new string[]{ "Guinea" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GP
        /// <summary>
        /// Guadeloupe
        /// </summary>
        public static Region GP { get { return _GP; } }
        private static Region _GP = new Region("GP", // Subtag
                                new string[]{ "Guadeloupe" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GQ
        /// <summary>
        /// Equatorial Guinea
        /// </summary>
        public static Region GQ { get { return _GQ; } }
        private static Region _GQ = new Region("GQ", // Subtag
                                new string[]{ "Equatorial Guinea" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GR
        /// <summary>
        /// Greece
        /// </summary>
        public static Region GR { get { return _GR; } }
        private static Region _GR = new Region("GR", // Subtag
                                new string[]{ "Greece" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GS
        /// <summary>
        /// South Georgia and the South Sandwich Islands
        /// </summary>
        public static Region GS { get { return _GS; } }
        private static Region _GS = new Region("GS", // Subtag
                                new string[]{ "South Georgia and the South Sandwich Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GT
        /// <summary>
        /// Guatemala
        /// </summary>
        public static Region GT { get { return _GT; } }
        private static Region _GT = new Region("GT", // Subtag
                                new string[]{ "Guatemala" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GU
        /// <summary>
        /// Guam
        /// </summary>
        public static Region GU { get { return _GU; } }
        private static Region _GU = new Region("GU", // Subtag
                                new string[]{ "Guam" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GW
        /// <summary>
        /// Guinea-Bissau
        /// </summary>
        public static Region GW { get { return _GW; } }
        private static Region _GW = new Region("GW", // Subtag
                                new string[]{ "Guinea-Bissau" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region GY
        /// <summary>
        /// Guyana
        /// </summary>
        public static Region GY { get { return _GY; } }
        private static Region _GY = new Region("GY", // Subtag
                                new string[]{ "Guyana" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region HK
        /// <summary>
        /// Hong Kong
        /// </summary>
        public static Region HK { get { return _HK; } }
        private static Region _HK = new Region("HK", // Subtag
                                new string[]{ "Hong Kong" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region HM
        /// <summary>
        /// Heard Island and McDonald Islands
        /// </summary>
        public static Region HM { get { return _HM; } }
        private static Region _HM = new Region("HM", // Subtag
                                new string[]{ "Heard Island and McDonald Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region HN
        /// <summary>
        /// Honduras
        /// </summary>
        public static Region HN { get { return _HN; } }
        private static Region _HN = new Region("HN", // Subtag
                                new string[]{ "Honduras" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region HR
        /// <summary>
        /// Croatia
        /// </summary>
        public static Region HR { get { return _HR; } }
        private static Region _HR = new Region("HR", // Subtag
                                new string[]{ "Croatia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region HT
        /// <summary>
        /// Haiti
        /// </summary>
        public static Region HT { get { return _HT; } }
        private static Region _HT = new Region("HT", // Subtag
                                new string[]{ "Haiti" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region HU
        /// <summary>
        /// Hungary
        /// </summary>
        public static Region HU { get { return _HU; } }
        private static Region _HU = new Region("HU", // Subtag
                                new string[]{ "Hungary" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region IC
        /// <summary>
        /// Canary Islands
        /// </summary>
        public static Region IC { get { return _IC; } }
        private static Region _IC = new Region("IC", // Subtag
                                new string[]{ "Canary Islands" }, // Description
                                new DateTime(2009, 7, 29 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region ID
        /// <summary>
        /// Indonesia
        /// </summary>
        public static Region ID { get { return _ID; } }
        private static Region _ID = new Region("ID", // Subtag
                                new string[]{ "Indonesia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region IE
        /// <summary>
        /// Ireland
        /// </summary>
        public static Region IE { get { return _IE; } }
        private static Region _IE = new Region("IE", // Subtag
                                new string[]{ "Ireland" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region IL
        /// <summary>
        /// Israel
        /// </summary>
        public static Region IL { get { return _IL; } }
        private static Region _IL = new Region("IL", // Subtag
                                new string[]{ "Israel" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region IM
        /// <summary>
        /// Isle of Man
        /// </summary>
        public static Region IM { get { return _IM; } }
        private static Region _IM = new Region("IM", // Subtag
                                new string[]{ "Isle of Man" }, // Description
                                new DateTime(2006, 3, 29 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region IN
        /// <summary>
        /// India
        /// </summary>
        public static Region IN { get { return _IN; } }
        private static Region _IN = new Region("IN", // Subtag
                                new string[]{ "India" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region IO
        /// <summary>
        /// British Indian Ocean Territory
        /// </summary>
        public static Region IO { get { return _IO; } }
        private static Region _IO = new Region("IO", // Subtag
                                new string[]{ "British Indian Ocean Territory" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region IQ
        /// <summary>
        /// Iraq
        /// </summary>
        public static Region IQ { get { return _IQ; } }
        private static Region _IQ = new Region("IQ", // Subtag
                                new string[]{ "Iraq" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region IR
        /// <summary>
        /// Islamic Republic of Iran
        /// </summary>
        public static Region IR { get { return _IR; } }
        private static Region _IR = new Region("IR", // Subtag
                                new string[]{ "Islamic Republic of Iran" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region IS
        /// <summary>
        /// Iceland
        /// </summary>
        public static Region IS { get { return _IS; } }
        private static Region _IS = new Region("IS", // Subtag
                                new string[]{ "Iceland" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region IT
        /// <summary>
        /// Italy
        /// </summary>
        public static Region IT { get { return _IT; } }
        private static Region _IT = new Region("IT", // Subtag
                                new string[]{ "Italy" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region JE
        /// <summary>
        /// Jersey
        /// </summary>
        public static Region JE { get { return _JE; } }
        private static Region _JE = new Region("JE", // Subtag
                                new string[]{ "Jersey" }, // Description
                                new DateTime(2006, 3, 29 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region JM
        /// <summary>
        /// Jamaica
        /// </summary>
        public static Region JM { get { return _JM; } }
        private static Region _JM = new Region("JM", // Subtag
                                new string[]{ "Jamaica" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region JO
        /// <summary>
        /// Jordan
        /// </summary>
        public static Region JO { get { return _JO; } }
        private static Region _JO = new Region("JO", // Subtag
                                new string[]{ "Jordan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region JP
        /// <summary>
        /// Japan
        /// </summary>
        public static Region JP { get { return _JP; } }
        private static Region _JP = new Region("JP", // Subtag
                                new string[]{ "Japan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KE
        /// <summary>
        /// Kenya
        /// </summary>
        public static Region KE { get { return _KE; } }
        private static Region _KE = new Region("KE", // Subtag
                                new string[]{ "Kenya" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KG
        /// <summary>
        /// Kyrgyzstan
        /// </summary>
        public static Region KG { get { return _KG; } }
        private static Region _KG = new Region("KG", // Subtag
                                new string[]{ "Kyrgyzstan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KH
        /// <summary>
        /// Cambodia
        /// </summary>
        public static Region KH { get { return _KH; } }
        private static Region _KH = new Region("KH", // Subtag
                                new string[]{ "Cambodia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KI
        /// <summary>
        /// Kiribati
        /// </summary>
        public static Region KI { get { return _KI; } }
        private static Region _KI = new Region("KI", // Subtag
                                new string[]{ "Kiribati" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KM
        /// <summary>
        /// Comoros
        /// </summary>
        public static Region KM { get { return _KM; } }
        private static Region _KM = new Region("KM", // Subtag
                                new string[]{ "Comoros" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KN
        /// <summary>
        /// Saint Kitts and Nevis
        /// </summary>
        public static Region KN { get { return _KN; } }
        private static Region _KN = new Region("KN", // Subtag
                                new string[]{ "Saint Kitts and Nevis" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KP
        /// <summary>
        /// Democratic People's Republic of Korea
        /// </summary>
        public static Region KP { get { return _KP; } }
        private static Region _KP = new Region("KP", // Subtag
                                new string[]{ "Democratic People's Republic of Korea" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KR
        /// <summary>
        /// Republic of Korea
        /// </summary>
        public static Region KR { get { return _KR; } }
        private static Region _KR = new Region("KR", // Subtag
                                new string[]{ "Republic of Korea" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KW
        /// <summary>
        /// Kuwait
        /// </summary>
        public static Region KW { get { return _KW; } }
        private static Region _KW = new Region("KW", // Subtag
                                new string[]{ "Kuwait" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KY
        /// <summary>
        /// Cayman Islands
        /// </summary>
        public static Region KY { get { return _KY; } }
        private static Region _KY = new Region("KY", // Subtag
                                new string[]{ "Cayman Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region KZ
        /// <summary>
        /// Kazakhstan
        /// </summary>
        public static Region KZ { get { return _KZ; } }
        private static Region _KZ = new Region("KZ", // Subtag
                                new string[]{ "Kazakhstan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LA
        /// <summary>
        /// Lao People's Democratic Republic
        /// </summary>
        public static Region LA { get { return _LA; } }
        private static Region _LA = new Region("LA", // Subtag
                                new string[]{ "Lao People's Democratic Republic" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LB
        /// <summary>
        /// Lebanon
        /// </summary>
        public static Region LB { get { return _LB; } }
        private static Region _LB = new Region("LB", // Subtag
                                new string[]{ "Lebanon" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LC
        /// <summary>
        /// Saint Lucia
        /// </summary>
        public static Region LC { get { return _LC; } }
        private static Region _LC = new Region("LC", // Subtag
                                new string[]{ "Saint Lucia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LI
        /// <summary>
        /// Liechtenstein
        /// </summary>
        public static Region LI { get { return _LI; } }
        private static Region _LI = new Region("LI", // Subtag
                                new string[]{ "Liechtenstein" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LK
        /// <summary>
        /// Sri Lanka
        /// </summary>
        public static Region LK { get { return _LK; } }
        private static Region _LK = new Region("LK", // Subtag
                                new string[]{ "Sri Lanka" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LR
        /// <summary>
        /// Liberia
        /// </summary>
        public static Region LR { get { return _LR; } }
        private static Region _LR = new Region("LR", // Subtag
                                new string[]{ "Liberia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LS
        /// <summary>
        /// Lesotho
        /// </summary>
        public static Region LS { get { return _LS; } }
        private static Region _LS = new Region("LS", // Subtag
                                new string[]{ "Lesotho" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LT
        /// <summary>
        /// Lithuania
        /// </summary>
        public static Region LT { get { return _LT; } }
        private static Region _LT = new Region("LT", // Subtag
                                new string[]{ "Lithuania" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LU
        /// <summary>
        /// Luxembourg
        /// </summary>
        public static Region LU { get { return _LU; } }
        private static Region _LU = new Region("LU", // Subtag
                                new string[]{ "Luxembourg" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LV
        /// <summary>
        /// Latvia
        /// </summary>
        public static Region LV { get { return _LV; } }
        private static Region _LV = new Region("LV", // Subtag
                                new string[]{ "Latvia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region LY
        /// <summary>
        /// Libya
        /// </summary>
        public static Region LY { get { return _LY; } }
        private static Region _LY = new Region("LY", // Subtag
                                new string[]{ "Libya" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MA
        /// <summary>
        /// Morocco
        /// </summary>
        public static Region MA { get { return _MA; } }
        private static Region _MA = new Region("MA", // Subtag
                                new string[]{ "Morocco" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MC
        /// <summary>
        /// Monaco
        /// </summary>
        public static Region MC { get { return _MC; } }
        private static Region _MC = new Region("MC", // Subtag
                                new string[]{ "Monaco" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MD
        /// <summary>
        /// Moldova
        /// </summary>
        public static Region MD { get { return _MD; } }
        private static Region _MD = new Region("MD", // Subtag
                                new string[]{ "Moldova" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region ME
        /// <summary>
        /// Montenegro
        /// </summary>
        public static Region ME { get { return _ME; } }
        private static Region _ME = new Region("ME", // Subtag
                                new string[]{ "Montenegro" }, // Description
                                new DateTime(2006, 10, 5 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MF
        /// <summary>
        /// Saint Martin (French part)
        /// </summary>
        public static Region MF { get { return _MF; } }
        private static Region _MF = new Region("MF", // Subtag
                                new string[]{ "Saint Martin (French part)" }, // Description
                                new DateTime(2007, 11, 2 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MG
        /// <summary>
        /// Madagascar
        /// </summary>
        public static Region MG { get { return _MG; } }
        private static Region _MG = new Region("MG", // Subtag
                                new string[]{ "Madagascar" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MH
        /// <summary>
        /// Marshall Islands
        /// </summary>
        public static Region MH { get { return _MH; } }
        private static Region _MH = new Region("MH", // Subtag
                                new string[]{ "Marshall Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MK
        /// <summary>
        /// The Former Yugoslav Republic of Macedonia
        /// </summary>
        public static Region MK { get { return _MK; } }
        private static Region _MK = new Region("MK", // Subtag
                                new string[]{ "The Former Yugoslav Republic of Macedonia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region ML
        /// <summary>
        /// Mali
        /// </summary>
        public static Region ML { get { return _ML; } }
        private static Region _ML = new Region("ML", // Subtag
                                new string[]{ "Mali" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MM
        /// <summary>
        /// Myanmar
        /// </summary>
        public static Region MM { get { return _MM; } }
        private static Region _MM = new Region("MM", // Subtag
                                new string[]{ "Myanmar" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MN
        /// <summary>
        /// Mongolia
        /// </summary>
        public static Region MN { get { return _MN; } }
        private static Region _MN = new Region("MN", // Subtag
                                new string[]{ "Mongolia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MO
        /// <summary>
        /// Macao
        /// </summary>
        public static Region MO { get { return _MO; } }
        private static Region _MO = new Region("MO", // Subtag
                                new string[]{ "Macao" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MP
        /// <summary>
        /// Northern Mariana Islands
        /// </summary>
        public static Region MP { get { return _MP; } }
        private static Region _MP = new Region("MP", // Subtag
                                new string[]{ "Northern Mariana Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MQ
        /// <summary>
        /// Martinique
        /// </summary>
        public static Region MQ { get { return _MQ; } }
        private static Region _MQ = new Region("MQ", // Subtag
                                new string[]{ "Martinique" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MR
        /// <summary>
        /// Mauritania
        /// </summary>
        public static Region MR { get { return _MR; } }
        private static Region _MR = new Region("MR", // Subtag
                                new string[]{ "Mauritania" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MS
        /// <summary>
        /// Montserrat
        /// </summary>
        public static Region MS { get { return _MS; } }
        private static Region _MS = new Region("MS", // Subtag
                                new string[]{ "Montserrat" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MT
        /// <summary>
        /// Malta
        /// </summary>
        public static Region MT { get { return _MT; } }
        private static Region _MT = new Region("MT", // Subtag
                                new string[]{ "Malta" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MU
        /// <summary>
        /// Mauritius
        /// </summary>
        public static Region MU { get { return _MU; } }
        private static Region _MU = new Region("MU", // Subtag
                                new string[]{ "Mauritius" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MV
        /// <summary>
        /// Maldives
        /// </summary>
        public static Region MV { get { return _MV; } }
        private static Region _MV = new Region("MV", // Subtag
                                new string[]{ "Maldives" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MW
        /// <summary>
        /// Malawi
        /// </summary>
        public static Region MW { get { return _MW; } }
        private static Region _MW = new Region("MW", // Subtag
                                new string[]{ "Malawi" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MX
        /// <summary>
        /// Mexico
        /// </summary>
        public static Region MX { get { return _MX; } }
        private static Region _MX = new Region("MX", // Subtag
                                new string[]{ "Mexico" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MY
        /// <summary>
        /// Malaysia
        /// </summary>
        public static Region MY { get { return _MY; } }
        private static Region _MY = new Region("MY", // Subtag
                                new string[]{ "Malaysia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region MZ
        /// <summary>
        /// Mozambique
        /// </summary>
        public static Region MZ { get { return _MZ; } }
        private static Region _MZ = new Region("MZ", // Subtag
                                new string[]{ "Mozambique" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NA
        /// <summary>
        /// Namibia
        /// </summary>
        public static Region NA { get { return _NA; } }
        private static Region _NA = new Region("NA", // Subtag
                                new string[]{ "Namibia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NC
        /// <summary>
        /// New Caledonia
        /// </summary>
        public static Region NC { get { return _NC; } }
        private static Region _NC = new Region("NC", // Subtag
                                new string[]{ "New Caledonia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NE
        /// <summary>
        /// Niger
        /// </summary>
        public static Region NE { get { return _NE; } }
        private static Region _NE = new Region("NE", // Subtag
                                new string[]{ "Niger" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NF
        /// <summary>
        /// Norfolk Island
        /// </summary>
        public static Region NF { get { return _NF; } }
        private static Region _NF = new Region("NF", // Subtag
                                new string[]{ "Norfolk Island" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NG
        /// <summary>
        /// Nigeria
        /// </summary>
        public static Region NG { get { return _NG; } }
        private static Region _NG = new Region("NG", // Subtag
                                new string[]{ "Nigeria" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NI
        /// <summary>
        /// Nicaragua
        /// </summary>
        public static Region NI { get { return _NI; } }
        private static Region _NI = new Region("NI", // Subtag
                                new string[]{ "Nicaragua" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NL
        /// <summary>
        /// Netherlands
        /// </summary>
        public static Region NL { get { return _NL; } }
        private static Region _NL = new Region("NL", // Subtag
                                new string[]{ "Netherlands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NO
        /// <summary>
        /// Norway
        /// </summary>
        public static Region NO { get { return _NO; } }
        private static Region _NO = new Region("NO", // Subtag
                                new string[]{ "Norway" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NP
        /// <summary>
        /// Nepal
        /// </summary>
        public static Region NP { get { return _NP; } }
        private static Region _NP = new Region("NP", // Subtag
                                new string[]{ "Nepal" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NR
        /// <summary>
        /// Nauru
        /// </summary>
        public static Region NR { get { return _NR; } }
        private static Region _NR = new Region("NR", // Subtag
                                new string[]{ "Nauru" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NT
        /// <summary>
        /// Neutral Zone
        /// </summary>
        public static Region NT { get { return _NT; } }
        private static Region _NT = new Region("NT", // Subtag
                                new string[]{ "Neutral Zone" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(1993, 7, 12 ), //Deprecated
                                                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NU
        /// <summary>
        /// Niue
        /// </summary>
        public static Region NU { get { return _NU; } }
        private static Region _NU = new Region("NU", // Subtag
                                new string[]{ "Niue" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region NZ
        /// <summary>
        /// New Zealand
        /// </summary>
        public static Region NZ { get { return _NZ; } }
        private static Region _NZ = new Region("NZ", // Subtag
                                new string[]{ "New Zealand" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region OM
        /// <summary>
        /// Oman
        /// </summary>
        public static Region OM { get { return _OM; } }
        private static Region _OM = new Region("OM", // Subtag
                                new string[]{ "Oman" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PA
        /// <summary>
        /// Panama
        /// </summary>
        public static Region PA { get { return _PA; } }
        private static Region _PA = new Region("PA", // Subtag
                                new string[]{ "Panama" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PE
        /// <summary>
        /// Peru
        /// </summary>
        public static Region PE { get { return _PE; } }
        private static Region _PE = new Region("PE", // Subtag
                                new string[]{ "Peru" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PF
        /// <summary>
        /// French Polynesia
        /// </summary>
        public static Region PF { get { return _PF; } }
        private static Region _PF = new Region("PF", // Subtag
                                new string[]{ "French Polynesia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PG
        /// <summary>
        /// Papua New Guinea
        /// </summary>
        public static Region PG { get { return _PG; } }
        private static Region _PG = new Region("PG", // Subtag
                                new string[]{ "Papua New Guinea" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PH
        /// <summary>
        /// Philippines
        /// </summary>
        public static Region PH { get { return _PH; } }
        private static Region _PH = new Region("PH", // Subtag
                                new string[]{ "Philippines" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PK
        /// <summary>
        /// Pakistan
        /// </summary>
        public static Region PK { get { return _PK; } }
        private static Region _PK = new Region("PK", // Subtag
                                new string[]{ "Pakistan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PL
        /// <summary>
        /// Poland
        /// </summary>
        public static Region PL { get { return _PL; } }
        private static Region _PL = new Region("PL", // Subtag
                                new string[]{ "Poland" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PM
        /// <summary>
        /// Saint Pierre and Miquelon
        /// </summary>
        public static Region PM { get { return _PM; } }
        private static Region _PM = new Region("PM", // Subtag
                                new string[]{ "Saint Pierre and Miquelon" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PN
        /// <summary>
        /// Pitcairn
        /// </summary>
        public static Region PN { get { return _PN; } }
        private static Region _PN = new Region("PN", // Subtag
                                new string[]{ "Pitcairn" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PR
        /// <summary>
        /// Puerto Rico
        /// </summary>
        public static Region PR { get { return _PR; } }
        private static Region _PR = new Region("PR", // Subtag
                                new string[]{ "Puerto Rico" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PS
        /// <summary>
        /// Occupied Palestinian Territory
        /// </summary>
        public static Region PS { get { return _PS; } }
        private static Region _PS = new Region("PS", // Subtag
                                new string[]{ "Occupied Palestinian Territory" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PT
        /// <summary>
        /// Portugal
        /// </summary>
        public static Region PT { get { return _PT; } }
        private static Region _PT = new Region("PT", // Subtag
                                new string[]{ "Portugal" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PW
        /// <summary>
        /// Palau
        /// </summary>
        public static Region PW { get { return _PW; } }
        private static Region _PW = new Region("PW", // Subtag
                                new string[]{ "Palau" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region PY
        /// <summary>
        /// Paraguay
        /// </summary>
        public static Region PY { get { return _PY; } }
        private static Region _PY = new Region("PY", // Subtag
                                new string[]{ "Paraguay" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QA
        /// <summary>
        /// Qatar
        /// </summary>
        public static Region QA { get { return _QA; } }
        private static Region _QA = new Region("QA", // Subtag
                                new string[]{ "Qatar" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QM
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QM { get { return _QM; } }
        private static Region _QM = new Region("qm", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QN
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QN { get { return _QN; } }
        private static Region _QN = new Region("qn", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QO
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QO { get { return _QO; } }
        private static Region _QO = new Region("qo", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QP
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QP { get { return _QP; } }
        private static Region _QP = new Region("qp", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QQ
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QQ { get { return _QQ; } }
        private static Region _QQ = new Region("qq", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QR
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QR { get { return _QR; } }
        private static Region _QR = new Region("qr", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QS
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QS { get { return _QS; } }
        private static Region _QS = new Region("qs", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QT
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QT { get { return _QT; } }
        private static Region _QT = new Region("qt", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QU
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QU { get { return _QU; } }
        private static Region _QU = new Region("qu", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QV
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QV { get { return _QV; } }
        private static Region _QV = new Region("qv", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QW
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QW { get { return _QW; } }
        private static Region _QW = new Region("qw", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QX
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QX { get { return _QX; } }
        private static Region _QX = new Region("qx", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QY
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QY { get { return _QY; } }
        private static Region _QY = new Region("qy", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region QZ
        /// <summary>
        /// Private use
        /// </summary>
        public static Region QZ { get { return _QZ; } }
        private static Region _QZ = new Region("qz", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region RE
        /// <summary>
        /// Réunion
        /// </summary>
        public static Region RE { get { return _RE; } }
        private static Region _RE = new Region("RE", // Subtag
                                new string[]{ "Réunion" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region RO
        /// <summary>
        /// Romania
        /// </summary>
        public static Region RO { get { return _RO; } }
        private static Region _RO = new Region("RO", // Subtag
                                new string[]{ "Romania" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region RS
        /// <summary>
        /// Serbia
        /// </summary>
        public static Region RS { get { return _RS; } }
        private static Region _RS = new Region("RS", // Subtag
                                new string[]{ "Serbia" }, // Description
                                new DateTime(2006, 10, 5 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region RU
        /// <summary>
        /// Russian Federation
        /// </summary>
        public static Region RU { get { return _RU; } }
        private static Region _RU = new Region("RU", // Subtag
                                new string[]{ "Russian Federation" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region RW
        /// <summary>
        /// Rwanda
        /// </summary>
        public static Region RW { get { return _RW; } }
        private static Region _RW = new Region("RW", // Subtag
                                new string[]{ "Rwanda" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SA
        /// <summary>
        /// Saudi Arabia
        /// </summary>
        public static Region SA { get { return _SA; } }
        private static Region _SA = new Region("SA", // Subtag
                                new string[]{ "Saudi Arabia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SB
        /// <summary>
        /// Solomon Islands
        /// </summary>
        public static Region SB { get { return _SB; } }
        private static Region _SB = new Region("SB", // Subtag
                                new string[]{ "Solomon Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SC
        /// <summary>
        /// Seychelles
        /// </summary>
        public static Region SC { get { return _SC; } }
        private static Region _SC = new Region("SC", // Subtag
                                new string[]{ "Seychelles" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SD
        /// <summary>
        /// Sudan
        /// </summary>
        public static Region SD { get { return _SD; } }
        private static Region _SD = new Region("SD", // Subtag
                                new string[]{ "Sudan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SE
        /// <summary>
        /// Sweden
        /// </summary>
        public static Region SE { get { return _SE; } }
        private static Region _SE = new Region("SE", // Subtag
                                new string[]{ "Sweden" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SG
        /// <summary>
        /// Singapore
        /// </summary>
        public static Region SG { get { return _SG; } }
        private static Region _SG = new Region("SG", // Subtag
                                new string[]{ "Singapore" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SH
        /// <summary>
        /// Saint Helena, Ascension and Tristan da Cunha
        /// </summary>
        public static Region SH { get { return _SH; } }
        private static Region _SH = new Region("SH", // Subtag
                                new string[]{ "Saint Helena", " Ascension and Tristan da Cunha" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SI
        /// <summary>
        /// Slovenia
        /// </summary>
        public static Region SI { get { return _SI; } }
        private static Region _SI = new Region("SI", // Subtag
                                new string[]{ "Slovenia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SJ
        /// <summary>
        /// Svalbard and Jan Mayen
        /// </summary>
        public static Region SJ { get { return _SJ; } }
        private static Region _SJ = new Region("SJ", // Subtag
                                new string[]{ "Svalbard and Jan Mayen" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SK
        /// <summary>
        /// Slovakia
        /// </summary>
        public static Region SK { get { return _SK; } }
        private static Region _SK = new Region("SK", // Subtag
                                new string[]{ "Slovakia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SL
        /// <summary>
        /// Sierra Leone
        /// </summary>
        public static Region SL { get { return _SL; } }
        private static Region _SL = new Region("SL", // Subtag
                                new string[]{ "Sierra Leone" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SM
        /// <summary>
        /// San Marino
        /// </summary>
        public static Region SM { get { return _SM; } }
        private static Region _SM = new Region("SM", // Subtag
                                new string[]{ "San Marino" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SN
        /// <summary>
        /// Senegal
        /// </summary>
        public static Region SN { get { return _SN; } }
        private static Region _SN = new Region("SN", // Subtag
                                new string[]{ "Senegal" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SO
        /// <summary>
        /// Somalia
        /// </summary>
        public static Region SO { get { return _SO; } }
        private static Region _SO = new Region("SO", // Subtag
                                new string[]{ "Somalia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SR
        /// <summary>
        /// Suriname
        /// </summary>
        public static Region SR { get { return _SR; } }
        private static Region _SR = new Region("SR", // Subtag
                                new string[]{ "Suriname" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SS
        /// <summary>
        /// South Sudan
        /// </summary>
        public static Region SS { get { return _SS; } }
        private static Region _SS = new Region("SS", // Subtag
                                new string[]{ "South Sudan" }, // Description
                                new DateTime(2011, 8, 25 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region ST
        /// <summary>
        /// Sao Tome and Principe
        /// </summary>
        public static Region ST { get { return _ST; } }
        private static Region _ST = new Region("ST", // Subtag
                                new string[]{ "Sao Tome and Principe" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SU
        /// <summary>
        /// Union of Soviet Socialist Republics
        /// </summary>
        public static Region SU { get { return _SU; } }
        private static Region _SU = new Region("SU", // Subtag
                                new string[]{ "Union of Soviet Socialist Republics" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(1992, 8, 30 ), //Deprecated
                                                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SV
        /// <summary>
        /// El Salvador
        /// </summary>
        public static Region SV { get { return _SV; } }
        private static Region _SV = new Region("SV", // Subtag
                                new string[]{ "El Salvador" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SX
        /// <summary>
        /// Sint Maarten (Dutch part)
        /// </summary>
        public static Region SX { get { return _SX; } }
        private static Region _SX = new Region("SX", // Subtag
                                new string[]{ "Sint Maarten (Dutch part)" }, // Description
                                new DateTime(2011, 1, 7 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SY
        /// <summary>
        /// Syrian Arab Republic
        /// </summary>
        public static Region SY { get { return _SY; } }
        private static Region _SY = new Region("SY", // Subtag
                                new string[]{ "Syrian Arab Republic" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region SZ
        /// <summary>
        /// Swaziland
        /// </summary>
        public static Region SZ { get { return _SZ; } }
        private static Region _SZ = new Region("SZ", // Subtag
                                new string[]{ "Swaziland" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TA
        /// <summary>
        /// Tristan da Cunha
        /// </summary>
        public static Region TA { get { return _TA; } }
        private static Region _TA = new Region("TA", // Subtag
                                new string[]{ "Tristan da Cunha" }, // Description
                                new DateTime(2009, 7, 29 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TC
        /// <summary>
        /// Turks and Caicos Islands
        /// </summary>
        public static Region TC { get { return _TC; } }
        private static Region _TC = new Region("TC", // Subtag
                                new string[]{ "Turks and Caicos Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TD
        /// <summary>
        /// Chad
        /// </summary>
        public static Region TD { get { return _TD; } }
        private static Region _TD = new Region("TD", // Subtag
                                new string[]{ "Chad" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TF
        /// <summary>
        /// French Southern Territories
        /// </summary>
        public static Region TF { get { return _TF; } }
        private static Region _TF = new Region("TF", // Subtag
                                new string[]{ "French Southern Territories" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TG
        /// <summary>
        /// Togo
        /// </summary>
        public static Region TG { get { return _TG; } }
        private static Region _TG = new Region("TG", // Subtag
                                new string[]{ "Togo" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TH
        /// <summary>
        /// Thailand
        /// </summary>
        public static Region TH { get { return _TH; } }
        private static Region _TH = new Region("TH", // Subtag
                                new string[]{ "Thailand" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TJ
        /// <summary>
        /// Tajikistan
        /// </summary>
        public static Region TJ { get { return _TJ; } }
        private static Region _TJ = new Region("TJ", // Subtag
                                new string[]{ "Tajikistan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TK
        /// <summary>
        /// Tokelau
        /// </summary>
        public static Region TK { get { return _TK; } }
        private static Region _TK = new Region("TK", // Subtag
                                new string[]{ "Tokelau" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TL
        /// <summary>
        /// Timor-Leste
        /// </summary>
        public static Region TL { get { return _TL; } }
        private static Region _TL = new Region("TL", // Subtag
                                new string[]{ "Timor-Leste" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TM
        /// <summary>
        /// Turkmenistan
        /// </summary>
        public static Region TM { get { return _TM; } }
        private static Region _TM = new Region("TM", // Subtag
                                new string[]{ "Turkmenistan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TN
        /// <summary>
        /// Tunisia
        /// </summary>
        public static Region TN { get { return _TN; } }
        private static Region _TN = new Region("TN", // Subtag
                                new string[]{ "Tunisia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TO
        /// <summary>
        /// Tonga
        /// </summary>
        public static Region TO { get { return _TO; } }
        private static Region _TO = new Region("TO", // Subtag
                                new string[]{ "Tonga" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TP
        /// <summary>
        /// East Timor
        /// </summary>
        public static Region TP { get { return _TP; } }
        private static Region _TP = new Region("TP", // Subtag
                                new string[]{ "East Timor" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(2002, 5, 20 ), //Deprecated
                                                                "TL", // PreferredValue
                                null); // Comments

        #endregion

        #region TR
        /// <summary>
        /// Turkey
        /// </summary>
        public static Region TR { get { return _TR; } }
        private static Region _TR = new Region("TR", // Subtag
                                new string[]{ "Turkey" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TT
        /// <summary>
        /// Trinidad and Tobago
        /// </summary>
        public static Region TT { get { return _TT; } }
        private static Region _TT = new Region("TT", // Subtag
                                new string[]{ "Trinidad and Tobago" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TV
        /// <summary>
        /// Tuvalu
        /// </summary>
        public static Region TV { get { return _TV; } }
        private static Region _TV = new Region("TV", // Subtag
                                new string[]{ "Tuvalu" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TW
        /// <summary>
        /// Taiwan, Province of China
        /// </summary>
        public static Region TW { get { return _TW; } }
        private static Region _TW = new Region("TW", // Subtag
                                new string[]{ "Taiwan", " Province of China" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region TZ
        /// <summary>
        /// United Republic of Tanzania
        /// </summary>
        public static Region TZ { get { return _TZ; } }
        private static Region _TZ = new Region("TZ", // Subtag
                                new string[]{ "United Republic of Tanzania" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region UA
        /// <summary>
        /// Ukraine
        /// </summary>
        public static Region UA { get { return _UA; } }
        private static Region _UA = new Region("UA", // Subtag
                                new string[]{ "Ukraine" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region UG
        /// <summary>
        /// Uganda
        /// </summary>
        public static Region UG { get { return _UG; } }
        private static Region _UG = new Region("UG", // Subtag
                                new string[]{ "Uganda" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region UM
        /// <summary>
        /// United States Minor Outlying Islands
        /// </summary>
        public static Region UM { get { return _UM; } }
        private static Region _UM = new Region("UM", // Subtag
                                new string[]{ "United States Minor Outlying Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region US
        /// <summary>
        /// United States
        /// </summary>
        public static Region US { get { return _US; } }
        private static Region _US = new Region("US", // Subtag
                                new string[]{ "United States" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region UY
        /// <summary>
        /// Uruguay
        /// </summary>
        public static Region UY { get { return _UY; } }
        private static Region _UY = new Region("UY", // Subtag
                                new string[]{ "Uruguay" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region UZ
        /// <summary>
        /// Uzbekistan
        /// </summary>
        public static Region UZ { get { return _UZ; } }
        private static Region _UZ = new Region("UZ", // Subtag
                                new string[]{ "Uzbekistan" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region VA
        /// <summary>
        /// Holy See (Vatican City State)
        /// </summary>
        public static Region VA { get { return _VA; } }
        private static Region _VA = new Region("VA", // Subtag
                                new string[]{ "Holy See (Vatican City State)" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region VC
        /// <summary>
        /// Saint Vincent and the Grenadines
        /// </summary>
        public static Region VC { get { return _VC; } }
        private static Region _VC = new Region("VC", // Subtag
                                new string[]{ "Saint Vincent and the Grenadines" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region VE
        /// <summary>
        /// Venezuela
        /// </summary>
        public static Region VE { get { return _VE; } }
        private static Region _VE = new Region("VE", // Subtag
                                new string[]{ "Venezuela" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region VG
        /// <summary>
        /// British Virgin Islands
        /// </summary>
        public static Region VG { get { return _VG; } }
        private static Region _VG = new Region("VG", // Subtag
                                new string[]{ "British Virgin Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region VI
        /// <summary>
        /// U.S. Virgin Islands
        /// </summary>
        public static Region VI { get { return _VI; } }
        private static Region _VI = new Region("VI", // Subtag
                                new string[]{ "U.S. Virgin Islands" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region VN
        /// <summary>
        /// Viet Nam
        /// </summary>
        public static Region VN { get { return _VN; } }
        private static Region _VN = new Region("VN", // Subtag
                                new string[]{ "Viet Nam" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region VU
        /// <summary>
        /// Vanuatu
        /// </summary>
        public static Region VU { get { return _VU; } }
        private static Region _VU = new Region("VU", // Subtag
                                new string[]{ "Vanuatu" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region WF
        /// <summary>
        /// Wallis and Futuna
        /// </summary>
        public static Region WF { get { return _WF; } }
        private static Region _WF = new Region("WF", // Subtag
                                new string[]{ "Wallis and Futuna" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region WS
        /// <summary>
        /// Samoa
        /// </summary>
        public static Region WS { get { return _WS; } }
        private static Region _WS = new Region("WS", // Subtag
                                new string[]{ "Samoa" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XA
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XA { get { return _XA; } }
        private static Region _XA = new Region("xa", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XB
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XB { get { return _XB; } }
        private static Region _XB = new Region("xb", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XC
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XC { get { return _XC; } }
        private static Region _XC = new Region("xc", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XD
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XD { get { return _XD; } }
        private static Region _XD = new Region("xd", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XE
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XE { get { return _XE; } }
        private static Region _XE = new Region("xe", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XF
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XF { get { return _XF; } }
        private static Region _XF = new Region("xf", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XG
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XG { get { return _XG; } }
        private static Region _XG = new Region("xg", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XH
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XH { get { return _XH; } }
        private static Region _XH = new Region("xh", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XI
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XI { get { return _XI; } }
        private static Region _XI = new Region("xi", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XJ
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XJ { get { return _XJ; } }
        private static Region _XJ = new Region("xj", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XK
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XK { get { return _XK; } }
        private static Region _XK = new Region("xk", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XL
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XL { get { return _XL; } }
        private static Region _XL = new Region("xl", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XM
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XM { get { return _XM; } }
        private static Region _XM = new Region("xm", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XN
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XN { get { return _XN; } }
        private static Region _XN = new Region("xn", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XO
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XO { get { return _XO; } }
        private static Region _XO = new Region("xo", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XP
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XP { get { return _XP; } }
        private static Region _XP = new Region("xp", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XQ
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XQ { get { return _XQ; } }
        private static Region _XQ = new Region("xq", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XR
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XR { get { return _XR; } }
        private static Region _XR = new Region("xr", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XS
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XS { get { return _XS; } }
        private static Region _XS = new Region("xs", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XT
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XT { get { return _XT; } }
        private static Region _XT = new Region("xt", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XU
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XU { get { return _XU; } }
        private static Region _XU = new Region("xu", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XV
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XV { get { return _XV; } }
        private static Region _XV = new Region("xv", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XW
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XW { get { return _XW; } }
        private static Region _XW = new Region("xw", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XX
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XX { get { return _XX; } }
        private static Region _XX = new Region("xx", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XY
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XY { get { return _XY; } }
        private static Region _XY = new Region("xy", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region XZ
        /// <summary>
        /// Private use
        /// </summary>
        public static Region XZ { get { return _XZ; } }
        private static Region _XZ = new Region("xz", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region YD
        /// <summary>
        /// Democratic Yemen
        /// </summary>
        public static Region YD { get { return _YD; } }
        private static Region _YD = new Region("YD", // Subtag
                                new string[]{ "Democratic Yemen" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(1990, 8, 14 ), //Deprecated
                                                                "YE", // PreferredValue
                                null); // Comments

        #endregion

        #region YE
        /// <summary>
        /// Yemen
        /// </summary>
        public static Region YE { get { return _YE; } }
        private static Region _YE = new Region("YE", // Subtag
                                new string[]{ "Yemen" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region YT
        /// <summary>
        /// Mayotte
        /// </summary>
        public static Region YT { get { return _YT; } }
        private static Region _YT = new Region("YT", // Subtag
                                new string[]{ "Mayotte" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region YU
        /// <summary>
        /// Yugoslavia
        /// </summary>
        /// <remarks>see BA, HR, ME, MK, RS, or SI</remarks>
        public static Region YU { get { return _YU; } }
        private static Region _YU = new Region("YU", // Subtag
                                new string[]{ "Yugoslavia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(2003, 7, 23 ), //Deprecated
                                                                null, // PreferredValue
                                "see BA, HR, ME, MK, RS, or SI"); // Comments

        #endregion

        #region ZA
        /// <summary>
        /// South Africa
        /// </summary>
        public static Region ZA { get { return _ZA; } }
        private static Region _ZA = new Region("ZA", // Subtag
                                new string[]{ "South Africa" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region ZM
        /// <summary>
        /// Zambia
        /// </summary>
        public static Region ZM { get { return _ZM; } }
        private static Region _ZM = new Region("ZM", // Subtag
                                new string[]{ "Zambia" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region ZR
        /// <summary>
        /// Zaire
        /// </summary>
        public static Region ZR { get { return _ZR; } }
        private static Region _ZR = new Region("ZR", // Subtag
                                new string[]{ "Zaire" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                new DateTime(1997, 7, 14 ), //Deprecated
                                                                "CD", // PreferredValue
                                null); // Comments

        #endregion

        #region ZW
        /// <summary>
        /// Zimbabwe
        /// </summary>
        public static Region ZW { get { return _ZW; } }
        private static Region _ZW = new Region("ZW", // Subtag
                                new string[]{ "Zimbabwe" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion

        #region ZZ
        /// <summary>
        /// Private use
        /// </summary>
        public static Region ZZ { get { return _ZZ; } }
        private static Region _ZZ = new Region("ZZ", // Subtag
                                new string[]{ "Private use" }, // Description
                                new DateTime(2005, 10, 16 ), // Added
                                null, // Deprecated
                                null, // PreferredValue
                                null); // Comments

        #endregion


        #region Region Collection
        private static object regionsLock = new object();
        private static Collection<Region> regions = null;
        public static ReadOnlyCollection<Region> Regions
        {
            get
            {
                if(regions == null) 
                {
                    lock(regionsLock) 
                    {
                        if(regions == null) 
                        {
                            regions = new Collection<Region>();
  
                            regions.Add(M49_001);
  
                            regions.Add(M49_002);
  
                            regions.Add(M49_003);
  
                            regions.Add(M49_005);
  
                            regions.Add(M49_009);
  
                            regions.Add(M49_011);
  
                            regions.Add(M49_013);
  
                            regions.Add(M49_014);
  
                            regions.Add(M49_015);
  
                            regions.Add(M49_017);
  
                            regions.Add(M49_018);
  
                            regions.Add(M49_019);
  
                            regions.Add(M49_021);
  
                            regions.Add(M49_029);
  
                            regions.Add(M49_030);
  
                            regions.Add(M49_034);
  
                            regions.Add(M49_035);
  
                            regions.Add(M49_039);
  
                            regions.Add(M49_053);
  
                            regions.Add(M49_054);
  
                            regions.Add(M49_057);
  
                            regions.Add(M49_061);
  
                            regions.Add(M49_142);
  
                            regions.Add(M49_143);
  
                            regions.Add(M49_145);
  
                            regions.Add(M49_150);
  
                            regions.Add(M49_151);
  
                            regions.Add(M49_154);
  
                            regions.Add(M49_155);
  
                            regions.Add(M49_419);
  
                            regions.Add(AA);
  
                            regions.Add(AC);
  
                            regions.Add(AD);
  
                            regions.Add(AE);
  
                            regions.Add(AF);
  
                            regions.Add(AG);
  
                            regions.Add(AI);
  
                            regions.Add(AL);
  
                            regions.Add(AM);
  
                            regions.Add(AN);
  
                            regions.Add(AO);
  
                            regions.Add(AQ);
  
                            regions.Add(AR);
  
                            regions.Add(AS);
  
                            regions.Add(AT);
  
                            regions.Add(AU);
  
                            regions.Add(AW);
  
                            regions.Add(AX);
  
                            regions.Add(AZ);
  
                            regions.Add(BA);
  
                            regions.Add(BB);
  
                            regions.Add(BD);
  
                            regions.Add(BE);
  
                            regions.Add(BF);
  
                            regions.Add(BG);
  
                            regions.Add(BH);
  
                            regions.Add(BI);
  
                            regions.Add(BJ);
  
                            regions.Add(BL);
  
                            regions.Add(BM);
  
                            regions.Add(BN);
  
                            regions.Add(BO);
  
                            regions.Add(BQ);
  
                            regions.Add(BR);
  
                            regions.Add(BS);
  
                            regions.Add(BT);
  
                            regions.Add(BU);
  
                            regions.Add(BV);
  
                            regions.Add(BW);
  
                            regions.Add(BY);
  
                            regions.Add(BZ);
  
                            regions.Add(CA);
  
                            regions.Add(CC);
  
                            regions.Add(CD);
  
                            regions.Add(CF);
  
                            regions.Add(CG);
  
                            regions.Add(CH);
  
                            regions.Add(CI);
  
                            regions.Add(CK);
  
                            regions.Add(CL);
  
                            regions.Add(CM);
  
                            regions.Add(CN);
  
                            regions.Add(CO);
  
                            regions.Add(CP);
  
                            regions.Add(CR);
  
                            regions.Add(CS);
  
                            regions.Add(CU);
  
                            regions.Add(CV);
  
                            regions.Add(CW);
  
                            regions.Add(CX);
  
                            regions.Add(CY);
  
                            regions.Add(CZ);
  
                            regions.Add(DD);
  
                            regions.Add(DE);
  
                            regions.Add(DG);
  
                            regions.Add(DJ);
  
                            regions.Add(DK);
  
                            regions.Add(DM);
  
                            regions.Add(DO);
  
                            regions.Add(DZ);
  
                            regions.Add(EA);
  
                            regions.Add(EC);
  
                            regions.Add(EE);
  
                            regions.Add(EG);
  
                            regions.Add(EH);
  
                            regions.Add(ER);
  
                            regions.Add(ES);
  
                            regions.Add(ET);
  
                            regions.Add(EU);
  
                            regions.Add(FI);
  
                            regions.Add(FJ);
  
                            regions.Add(FK);
  
                            regions.Add(FM);
  
                            regions.Add(FO);
  
                            regions.Add(FR);
  
                            regions.Add(FX);
  
                            regions.Add(GA);
  
                            regions.Add(GB);
  
                            regions.Add(GD);
  
                            regions.Add(GE);
  
                            regions.Add(GF);
  
                            regions.Add(GG);
  
                            regions.Add(GH);
  
                            regions.Add(GI);
  
                            regions.Add(GL);
  
                            regions.Add(GM);
  
                            regions.Add(GN);
  
                            regions.Add(GP);
  
                            regions.Add(GQ);
  
                            regions.Add(GR);
  
                            regions.Add(GS);
  
                            regions.Add(GT);
  
                            regions.Add(GU);
  
                            regions.Add(GW);
  
                            regions.Add(GY);
  
                            regions.Add(HK);
  
                            regions.Add(HM);
  
                            regions.Add(HN);
  
                            regions.Add(HR);
  
                            regions.Add(HT);
  
                            regions.Add(HU);
  
                            regions.Add(IC);
  
                            regions.Add(ID);
  
                            regions.Add(IE);
  
                            regions.Add(IL);
  
                            regions.Add(IM);
  
                            regions.Add(IN);
  
                            regions.Add(IO);
  
                            regions.Add(IQ);
  
                            regions.Add(IR);
  
                            regions.Add(IS);
  
                            regions.Add(IT);
  
                            regions.Add(JE);
  
                            regions.Add(JM);
  
                            regions.Add(JO);
  
                            regions.Add(JP);
  
                            regions.Add(KE);
  
                            regions.Add(KG);
  
                            regions.Add(KH);
  
                            regions.Add(KI);
  
                            regions.Add(KM);
  
                            regions.Add(KN);
  
                            regions.Add(KP);
  
                            regions.Add(KR);
  
                            regions.Add(KW);
  
                            regions.Add(KY);
  
                            regions.Add(KZ);
  
                            regions.Add(LA);
  
                            regions.Add(LB);
  
                            regions.Add(LC);
  
                            regions.Add(LI);
  
                            regions.Add(LK);
  
                            regions.Add(LR);
  
                            regions.Add(LS);
  
                            regions.Add(LT);
  
                            regions.Add(LU);
  
                            regions.Add(LV);
  
                            regions.Add(LY);
  
                            regions.Add(MA);
  
                            regions.Add(MC);
  
                            regions.Add(MD);
  
                            regions.Add(ME);
  
                            regions.Add(MF);
  
                            regions.Add(MG);
  
                            regions.Add(MH);
  
                            regions.Add(MK);
  
                            regions.Add(ML);
  
                            regions.Add(MM);
  
                            regions.Add(MN);
  
                            regions.Add(MO);
  
                            regions.Add(MP);
  
                            regions.Add(MQ);
  
                            regions.Add(MR);
  
                            regions.Add(MS);
  
                            regions.Add(MT);
  
                            regions.Add(MU);
  
                            regions.Add(MV);
  
                            regions.Add(MW);
  
                            regions.Add(MX);
  
                            regions.Add(MY);
  
                            regions.Add(MZ);
  
                            regions.Add(NA);
  
                            regions.Add(NC);
  
                            regions.Add(NE);
  
                            regions.Add(NF);
  
                            regions.Add(NG);
  
                            regions.Add(NI);
  
                            regions.Add(NL);
  
                            regions.Add(NO);
  
                            regions.Add(NP);
  
                            regions.Add(NR);
  
                            regions.Add(NT);
  
                            regions.Add(NU);
  
                            regions.Add(NZ);
  
                            regions.Add(OM);
  
                            regions.Add(PA);
  
                            regions.Add(PE);
  
                            regions.Add(PF);
  
                            regions.Add(PG);
  
                            regions.Add(PH);
  
                            regions.Add(PK);
  
                            regions.Add(PL);
  
                            regions.Add(PM);
  
                            regions.Add(PN);
  
                            regions.Add(PR);
  
                            regions.Add(PS);
  
                            regions.Add(PT);
  
                            regions.Add(PW);
  
                            regions.Add(PY);
  
                            regions.Add(QA);
  
                            regions.Add(QM);
  
                            regions.Add(QN);
  
                            regions.Add(QO);
  
                            regions.Add(QP);
  
                            regions.Add(QQ);
  
                            regions.Add(QR);
  
                            regions.Add(QS);
  
                            regions.Add(QT);
  
                            regions.Add(QU);
  
                            regions.Add(QV);
  
                            regions.Add(QW);
  
                            regions.Add(QX);
  
                            regions.Add(QY);
  
                            regions.Add(QZ);
  
                            regions.Add(RE);
  
                            regions.Add(RO);
  
                            regions.Add(RS);
  
                            regions.Add(RU);
  
                            regions.Add(RW);
  
                            regions.Add(SA);
  
                            regions.Add(SB);
  
                            regions.Add(SC);
  
                            regions.Add(SD);
  
                            regions.Add(SE);
  
                            regions.Add(SG);
  
                            regions.Add(SH);
  
                            regions.Add(SI);
  
                            regions.Add(SJ);
  
                            regions.Add(SK);
  
                            regions.Add(SL);
  
                            regions.Add(SM);
  
                            regions.Add(SN);
  
                            regions.Add(SO);
  
                            regions.Add(SR);
  
                            regions.Add(SS);
  
                            regions.Add(ST);
  
                            regions.Add(SU);
  
                            regions.Add(SV);
  
                            regions.Add(SX);
  
                            regions.Add(SY);
  
                            regions.Add(SZ);
  
                            regions.Add(TA);
  
                            regions.Add(TC);
  
                            regions.Add(TD);
  
                            regions.Add(TF);
  
                            regions.Add(TG);
  
                            regions.Add(TH);
  
                            regions.Add(TJ);
  
                            regions.Add(TK);
  
                            regions.Add(TL);
  
                            regions.Add(TM);
  
                            regions.Add(TN);
  
                            regions.Add(TO);
  
                            regions.Add(TP);
  
                            regions.Add(TR);
  
                            regions.Add(TT);
  
                            regions.Add(TV);
  
                            regions.Add(TW);
  
                            regions.Add(TZ);
  
                            regions.Add(UA);
  
                            regions.Add(UG);
  
                            regions.Add(UM);
  
                            regions.Add(US);
  
                            regions.Add(UY);
  
                            regions.Add(UZ);
  
                            regions.Add(VA);
  
                            regions.Add(VC);
  
                            regions.Add(VE);
  
                            regions.Add(VG);
  
                            regions.Add(VI);
  
                            regions.Add(VN);
  
                            regions.Add(VU);
  
                            regions.Add(WF);
  
                            regions.Add(WS);
  
                            regions.Add(XA);
  
                            regions.Add(XB);
  
                            regions.Add(XC);
  
                            regions.Add(XD);
  
                            regions.Add(XE);
  
                            regions.Add(XF);
  
                            regions.Add(XG);
  
                            regions.Add(XH);
  
                            regions.Add(XI);
  
                            regions.Add(XJ);
  
                            regions.Add(XK);
  
                            regions.Add(XL);
  
                            regions.Add(XM);
  
                            regions.Add(XN);
  
                            regions.Add(XO);
  
                            regions.Add(XP);
  
                            regions.Add(XQ);
  
                            regions.Add(XR);
  
                            regions.Add(XS);
  
                            regions.Add(XT);
  
                            regions.Add(XU);
  
                            regions.Add(XV);
  
                            regions.Add(XW);
  
                            regions.Add(XX);
  
                            regions.Add(XY);
  
                            regions.Add(XZ);
  
                            regions.Add(YD);
  
                            regions.Add(YE);
  
                            regions.Add(YT);
  
                            regions.Add(YU);
  
                            regions.Add(ZA);
  
                            regions.Add(ZM);
  
                            regions.Add(ZR);
  
                            regions.Add(ZW);
  
                            regions.Add(ZZ);
                        }
                    }
                }
                return new ReadOnlyCollection<Region>(regions);
            }

        }
        #endregion
        #endregion


    }


//
}
