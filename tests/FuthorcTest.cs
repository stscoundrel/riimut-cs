using System;
using Xunit;
using Riimut;

namespace RiimutTest
{
    public class FuthorcTests
    {
        [Fact]
        public void Transforms_Letters_To_Futhorc()
        {
            string letters = "aábcdðeéfghiíïʒjklmnŋoóǫpqrstuúvwxyýzåäæœöøþ ";
            string runes = "ᚪᚪᛒᚳᛞᛞᛖᛖᚠᚷᚻᛁᛇᛇᛇᛡᚳᛚᛗᚾᛝᚩᚩᚩᛈᚳᚱᛋᛏᚢᚢᚹᚹᛉᚣᚣᛉᚩᚫᚫᛟᛟᛟᚦ:";

            string result = Futhorc.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void Transforms_Runes_To_Letters()
        {
            string runes = "ᚠᚢᚦᚩᚱᚳᚷᚹᚻᚾᛁᛡᛄᛇᛈᛉᛋᚴᛏᛒᛖᛗᛚᛝᛟᛞᚪᚫᚣᛠ:";
            string letters = "fuþorcgwhnijjïpxsstbemlŋœdaæyea ";

            string result = Futhorc.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }

        [Fact]
        public void Transforms_West_Saxon_Text_To_Futhorc_Runes()
        {
            // From 8th century Franks Casket, in late West Saxon.
            string letters = "fisc.flodu.ahofonferg | enberig |";
            string runes = "ᚠᛁᛋᚳ.ᚠᛚᚩᛞᚢ.ᚪᚻᚩᚠᚩᚾᚠᛖᚱᚷ:|:ᛖᚾᛒᛖᚱᛁᚷ:|";

            string result = Futhorc.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void Transforms_West_Saxon_Futhorc_To_Latin_Text()
        {
            // From 8th century Franks Casket, in late West Saxon.
            string runes = "ᚠᛁᛋᚳ.ᚠᛚᚩᛞᚢ.ᚪᚻᚩᚠᚩᚾᚠᛖᚱᚷ:|:ᛖᚾᛒᛖᚱᛁᚷ:|";
            string letters = "fisc.flodu.ahofonferg | enberig |";

            string result = Futhorc.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }
    }
}
