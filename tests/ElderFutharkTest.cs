using System;
using Xunit;
using Riimut;

namespace RiimutTest
{
    public class ElderFutharkTests
    {
        [Fact]
        public void TransformsLettersToElderFuthark()
        {
            string letters = "aábcdðeéfghiíjklmnŋoópqrstþuúvwxyýzåäæœöøǫþ";
            string runes = "ᚨᚨᛒᚲᛞᚦᛖᛖᚠᚷᚻᛁᛁᛃᚲᛚᛗᚾᛜᛟᛟᛈᚲᚱᛋᛏᚦᚢᚢᚹᚹᛋᛁᛁᛉᛟᛇᛇᛟᚢᚢᛟᚦ";

            Dialect elderFuthark = new ElderFuthark();
            string result = elderFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsRunesToLetters()
        {
            string runes = "ᚠᚢᚦᚨᚱᚲᚷᚹᚺᚻᚾᛁᛃᛇᛈᛉᛊᛋᛏᛒᛖᛗᛚᛜᛝᛟᛞ:";
            string letters = "fuþarkgwhhnijïpzsstbemlŋŋod ";

            Dialect elderFuthark = new ElderFuthark();
            string result = elderFuthark.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }

        [Fact]
        public void TransformsTextContentToElderFuthark()
        {
            // From 4th century axe in Jutland
            string letters = "wagagastiz alu wihgu sikijaz aiþalataz";
            string runes = "ᚹᚨᚷᚨᚷᚨᛋᛏᛁᛉ:ᚨᛚᚢ:ᚹᛁᚻᚷᚢ:ᛋᛁᚲᛁᛃᚨᛉ:ᚨᛁᚦᚨᛚᚨᛏᚨᛉ";

            Dialect elderFuthark = new ElderFuthark();
            string result = elderFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsElderFutharkContentToText()
        {
            // From 4th century axe in Jutland
            string runes = "ᚹᚨᚷᚨᚷᚨᛋᛏᛁᛉ:ᚨᛚᚢ:ᚹᛁᚻᚷᚢ:ᛋᛁᚲᛁᛃᚨᛉ:ᚨᛁᚦᚨᛚᚨᛏᚨᛉ";
            string letters = "wagagastiz alu wihgu sikijaz aiþalataz";

            Dialect elderFuthark = new ElderFuthark();
            string result = elderFuthark.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }
    }
}
