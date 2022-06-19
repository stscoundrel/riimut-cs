using System;
using Xunit;
using Riimut;

namespace RiimutTest
{
    public class MedievalFuthorkTests
    {
        [Fact]
        public void TransformsLettersToMedievalFuthork()
        {
            string letters = "aábcdðeéfghiíjklmnoóǫpqrstuúvwxyýzåäæœöøþ ";
            string runes = "ᛆᛆᛒᚴᚦᚦᚽᚽᚠᚵᚼᛁᛁᛁᚴᛚᛘᚿᚮᚮᚰᛕᚴᚱᛋᛏᚢᚢᚠᚠᛋᛦᛦᛋᚮᛅᛅᚯᚯᚯᚦ:";

            Dialect medievalFuthork = new MedievalFuthork();
            string result = medievalFuthork.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsRunesToLetters()
        {
            string runes = "ᚠᚢᚦᚮᚱᚴᚼᚿᛁᛆᛌᛋᛐᛏᛒᛘᛚᛦᚯᛅᚰᛕᚽ:";
            string letters = "fuþorkhniassttbmlyøæǫᴘe ";

            Dialect medievalFuthork = new MedievalFuthork();
            string result = medievalFuthork.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }

        [Fact]
        public void TransformsLordsPrayerToMedievalFuthork()
        {
            string letters = "Faðer uor som ast i himlüm, halgað warðe þit nama";
            string runes = "ᚠᛆᚦᚽᚱ:ᚢᚮᚱ:ᛋᚮᛘ:ᛆᛋᛏ:ᛁ:ᚼᛁᛘᛚᚢᛘ,:ᚼᛆᛚᚵᛆᚦ:ᚠᛆᚱᚦᚽ:ᚦᛁᛏ:ᚿᛆᛘᛆ";

            Dialect medievalFuthork = new MedievalFuthork();
            string result = medievalFuthork.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsLordsPrayerFromRunesToLatinLetters()
        {
            string runes = "ᚠᛆᚦᚽᚱ:ᚢᚮᚱ:ᛋᚮᛘ:ᛆᛋᛏ:ᛁ:ᚼᛁᛘᛚᚢᛘ:ᚼᛆᛚᚵᛆᚦ:ᚠᛆᚱᚦᚽ:ᚦᛁᛏ:ᚿᛆᛘᛆ";
            string letters = "faþer uor som ast i himlum halgaþ farþe þit nama"; // Wont tell apart eth & thorn in mid sentence.

            Dialect medievalFuthork = new MedievalFuthork();
            string result = medievalFuthork.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }
    }
}
