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
    }
}
