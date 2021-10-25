using System;
using Xunit;
using Riimut;

namespace RiimutTest
{
    public class YoungerFutharkTests
    {
        [Fact]
        public void Transforms_Letters_To_Younger_Futhark()
        {
            string letters = "aábcdðeéfghiíjklmnoópqrstþuúvwxyýzåäæöøǫþ";
            string runes = "ᛅᛅᛒᛋᛏᚦᛁᛁᚠᚴᚼᛁᛁᛁᚴᛚᛘᚾᚢᚢᛒᚴᚱᛋᛏᚦᚢᚢᚢᚢᛋᚢᚢᛋᚢᛅᛅᚢᚢᚢᚦ";

            string result = YoungerFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void Transforms_Text_Content_To_Younger_Futhark()
        {
            // From Old Groms runestone.
            string letters = "auk tani karþi kristna";
            string runes = "ᛅᚢᚴ:ᛏᛅᚾᛁ:ᚴᛅᚱᚦᛁ:ᚴᚱᛁᛋᛏᚾᛅ";

            string result = YoungerFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void Transforms_Runes_To_Letters()
        {
            string runes = "ᚠᚢᚦᚬᚱᚴᚼᚽᚾᚿᛁᛅᛆᛋᛌᛏᛐᛒᛘᛚᛦ:";
            string letters ="fuþorkhhnniaassttbmlR ";

            string result = YoungerFuthark.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }

        [Fact]
        public void Transforms_Rune_Content_To_Latin_Letters()
        {
            // From Old Groms runestone.
            string runes = "ᛅᚢᚴ:ᛏᛅᚾᛁ:ᚴᛅᚱᚦᛁ:ᚴᚱᛁᛋᛏᚾᛅ";
            string letters ="auk tani karþi kristna";

            string result = YoungerFuthark.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }
    }
}
