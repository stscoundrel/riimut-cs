using System;
using Xunit;
using Riimut;

namespace RiimutTest
{
    public class FuthorcTests
    {
        [Fact]
        public void TransformsLettersToFuthorc()
        {
            string letters = "aábcdðeéfghiíïʒjklmnŋoóǫpqrstuúvwxyýzåäæœöøþ ";
            string runes = "ᚪᚪᛒᚳᛞᛞᛖᛖᚠᚷᚻᛁᛇᛇᛇᛡᚳᛚᛗᚾᛝᚩᚩᚩᛈᚳᚱᛋᛏᚢᚢᚹᚹᛉᚣᚣᛉᚩᚫᚫᛟᛟᛟᚦ:";

            Dialect futhorc = new Futhorc();
            string result = futhorc.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsRunesToLetters()
        {
            string runes = "ᚠᚢᚦᚩᚱᚳᚷᚹᚻᚾᛁᛡᛄᛇᛈᛉᛋᚴᛏᛒᛖᛗᛚᛝᛟᛞᚪᚫᚣᛠ:";
            string letters = "fuþorcgwhnijjïpxsstbemlŋœdaæyea ";

            Dialect futhorc = new Futhorc();
            string result = futhorc.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }

        [Fact]
        public void TransformsWestSaxonTextToFuthorcRunes()
        {
            // From 8th century Franks Casket, in late West Saxon.
            string letters = "fisc.flodu.ahofonferg | enberig |";
            string runes = "ᚠᛁᛋᚳ.ᚠᛚᚩᛞᚢ.ᚪᚻᚩᚠᚩᚾᚠᛖᚱᚷ:|:ᛖᚾᛒᛖᚱᛁᚷ:|";

            Dialect futhorc = new Futhorc();
            string result = futhorc.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsWestSaxonFuthorcToLatinText()
        {
            // From 8th century Franks Casket, in late West Saxon.
            string runes = "ᚠᛁᛋᚳ.ᚠᛚᚩᛞᚢ.ᚪᚻᚩᚠᚩᚾᚠᛖᚱᚷ:|:ᛖᚾᛒᛖᚱᛁᚷ:|";
            string letters = "fisc.flodu.ahofonferg | enberig |";

            Dialect futhorc = new Futhorc();
            string result = futhorc.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }
    }
}
