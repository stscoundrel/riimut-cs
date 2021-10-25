using System;
using Xunit;
using Riimut;

namespace RiimutTest
{
    public class MedievalFuthorkTests
    {
        [Fact]
        public void Transforms_Letters_To_Medieval_Futhork()
        {
            string letters = "aábcdðeéfghiíjklmnoóǫpqrstuúvwxyýzåäæœöøþ ";
            string runes = "ᛆᛆᛒᚴᚦᚦᚽᚽᚠᚵᚼᛁᛁᛁᚴᛚᛘᚿᚮᚮᚰᛕᚴᚱᛋᛏᚢᚢᚠᚠᛋᛦᛦᛋᚮᛅᛅᚯᚯᚯᚦ:";

            string result = MedievalFuthork.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void Transforms_Runes_To_Letters()
        {
            string runes = "ᚠᚢᚦᚮᚱᚴᚼᚿᛁᛆᛌᛋᛐᛏᛒᛘᛚᛦᚯᛅᚰᛕᚽ:";
            string letters = "fuþorkhniassttbmlyøæǫᴘe ";

            string result = MedievalFuthork.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }

        [Fact]
        public void Transforms_Lords_Prayer_To_Medieval_Futhork()
        {
            string letters = "Faðer uor som ast i himlüm, halgað warðe þit nama";
            string runes = "ᚠᛆᚦᚽᚱ:ᚢᚮᚱ:ᛋᚮᛘ:ᛆᛋᛏ:ᛁ:ᚼᛁᛘᛚᚢᛘ,:ᚼᛆᛚᚵᛆᚦ:ᚠᛆᚱᚦᚽ:ᚦᛁᛏ:ᚿᛆᛘᛆ";

            string result = MedievalFuthork.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void Transforms_Lords_Prayer_From_Runes_To_Latin_Letters()
        {
            string runes = "ᚠᛆᚦᚽᚱ:ᚢᚮᚱ:ᛋᚮᛘ:ᛆᛋᛏ:ᛁ:ᚼᛁᛘᛚᚢᛘ:ᚼᛆᛚᚵᛆᚦ:ᚠᛆᚱᚦᚽ:ᚦᛁᛏ:ᚿᛆᛘᛆ";
            string letters = "faþer uor som ast i himlum halgaþ farþe þit nama"; // Wont tell apart eth & thorn in mid sentence.

            string result = MedievalFuthork.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }
    }
}
