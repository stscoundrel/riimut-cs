using Xunit;
using Riimut;

namespace RiimutTest
{
    public class StavelessFutharkTests
    {
        [Fact]
        public void TransformsLettersToStavelessFuthark()
        {
            string letters = "aábcdðeéfghiíjklmnoópqrRstþuúvwxyýzåäæöøǫþ ";
            string runes = "⸝⸝ˏ╵⸍וᛁᛁᛙᛍᚽᛁᛁᛁᛍ⸌⠃⸜ˎˎˏᛍ◟⡄╵⸍ו╮╮╮╮╵╮╮╵ˎ⸝⸝ˎˎˎו:";

            Dialect StavelessFuthark = new StavelessFuthark();
            string result = StavelessFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsRunesToLetters()
        {
            string runes = "ᛙ╮וˎ⡄ᛍᚽ⸜ᛁ⸝╵⸍ˏ⠃⸌⡄:";
            string letters = "fuþoRkhniastbmlR ";

            Dialect StavelessFuthark = new StavelessFuthark();
            string result = StavelessFuthark.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }

        [Fact]
        public void TransformsTextContentToStavelessFuthark()
        {
            // From Old Norse text in Hög runestone.
            string letters = "kuþniutr þru sun lit rita stin þina ak bru kirþi aftiʀ bruþr sina asbiurn ak at kuþlaf";
            string runes = "ᛍ╮ו⸜ᛁ╮⸍◟:ו◟╮:╵╮⸜:⸌ᛁ⸍:◟ᛁ⸍⸝:╵⸍ᛁ⸜:וᛁ⸜⸝:⸝ᛍ:ˏ◟╮:ᛍᛁ◟וᛁ:⸝ᛙ⸍ᛁʀ:ˏ◟╮ו◟:╵ᛁ⸜⸝:⸝╵ˏᛁ╮◟⸜:⸝ᛍ:⸝⸍:ᛍ╮ו⸌⸝ᛙ";

            Dialect StavelessFuthark = new StavelessFuthark();
            string result = StavelessFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsStavelessFutharkContentToText()
        {
            // From Old Norse text in Hög runestone.
            string runes = "⸌ᛁ⸍:⡄ᛁ⸍⸝:╵⸍ᛁ⸜:וᛁ⸜⸝";
            string letters = "lit Rita stin þina";

            Dialect StavelessFuthark = new StavelessFuthark();
            string result = StavelessFuthark.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }
    }
}
