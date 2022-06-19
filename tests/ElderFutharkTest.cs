using System;
using Xunit;
using Riimut;

namespace RiimutTest
{
    public class ElderFutharkTests
    {
        [Fact]
        public void Transforms_Letters_To_Elder_Futhark()
        {
            string letters = "aábcdðeéfghiíjklmnŋoópqrstþuúvwxyýzåäæöøǫþ";
            string runes = "ᚨᚨᛒᚲᛞᚦᛖᛖᚠᚷᚻᛁᛁᛃᚲᛚᛗᚾᛜᛟᛟᛈᚲᚱᛋᛏᚦᚢᚢᚹᚹᛋᛁᛁᛉᛟᛇᛇᚢᚢᛟᚦ";

            Dialect elderFuthark = new ElderFuthark();
            string result = elderFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void Transforms_Runes_To_Letters()
        {
            string runes = "ᚠᚢᚦᚨᚱᚲᚷᚹᚺᚻᚾᛁᛃᛇᛈᛉᛊᛋᛏᛒᛖᛗᛚᛜᛝᛟᛞ:";
            string letters = "fuþarkgwhhnijïpzsstbemlŋŋod ";

            Dialect elderFuthark = new ElderFuthark();
            string result = elderFuthark.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }

        [Fact]
        public void Transforms_Text_Content_To_Elder_Futhark()
        {
            // From 4th century axe in Jutland
            string letters = "wagagastiz alu wihgu sikijaz aiþalataz";
            string runes = "ᚹᚨᚷᚨᚷᚨᛋᛏᛁᛉ:ᚨᛚᚢ:ᚹᛁᚻᚷᚢ:ᛋᛁᚲᛁᛃᚨᛉ:ᚨᛁᚦᚨᛚᚨᛏᚨᛉ";

            Dialect elderFuthark = new ElderFuthark();
            string result = elderFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void Transforms_Elder_Futhark_Content_To_Text()
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
