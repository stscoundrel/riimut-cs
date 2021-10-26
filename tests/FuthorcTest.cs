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
    }
}
