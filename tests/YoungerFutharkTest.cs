using System;
using Xunit;
using Riimut;

namespace RiimutTest
{
    public class YoungerFutharkTests
    {
        [Fact]
        public void TransformsLettersToYoungerFuthark()
        {
            string letters = "aábcdðeéfghiíjklmnoópqrstþuúvwxyýzåäæöøǫþ";
            string runes = "ᛅᛅᛒᛋᛏᚦᛁᛁᚠᚴᚼᛁᛁᛁᚴᛚᛘᚾᚢᚢᛒᚴᚱᛋᛏᚦᚢᚢᚢᚢᛋᚢᚢᛋᚢᛅᛅᚢᚢᚢᚦ";

            Dialect youngerFuthark = new YoungerFuthark();
            string result = youngerFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsTextContentToYoungerFuthark()
        {
            // From Old Groms runestone.
            string letters = "auk tani karþi kristna";
            string runes = "ᛅᚢᚴ:ᛏᛅᚾᛁ:ᚴᛅᚱᚦᛁ:ᚴᚱᛁᛋᛏᚾᛅ";

            Dialect youngerFuthark = new YoungerFuthark();
            string result = youngerFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsRunesToLetters()
        {
            string runes = "ᚠᚢᚦᚬᚱᚴᚼᚽᚾᚿᛁᛅᛆᛋᛌᛏᛐᛒᛘᛚᛦ:";
            string letters = "fuþorkhhnniaassttbmlR ";

            Dialect youngerFuthark = new YoungerFuthark();
            string result = youngerFuthark.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }

        [Fact]
        public void TransformsRuneContentToLatinLetters()
        {
            // From Old Groms runestone.
            string runes = "ᛅᚢᚴ:ᛏᛅᚾᛁ:ᚴᛅᚱᚦᛁ:ᚴᚱᛁᛋᛏᚾᛅ";
            string letters = "auk tani karþi kristna";

            Dialect youngerFuthark = new YoungerFuthark();
            string result = youngerFuthark.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }
    }
}
