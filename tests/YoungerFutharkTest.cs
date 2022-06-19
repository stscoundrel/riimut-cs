using System;
using Xunit;
using Riimut;

namespace RiimutTest
{
    public class YoungerFutharkTests
    {
        [Fact]
        public void DefaultLetterTransform()
        {
            string letters = "aábcdðeéfghiíjklmnoópqrstþuúvwxyýzåäæöøǫþ";
            string runes = "ᛅᛅᛒᛋᛏᚦᛁᛁᚠᚴᚼᛁᛁᛁᚴᛚᛘᚾᚢᚢᛒᚴᚱᛋᛏᚦᚢᚢᚢᚢᛋᚢᚢᛋᚢᛅᛅᚢᚢᚢᚦ";

            YoungerFuthark youngerFuthark = new YoungerFuthark();
            string result = youngerFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsLettersToLongBranchRunes()
        {
            string letters = "aábcdðeéfghiíjklmnoópqrstþuúvwxyýzåäæöøǫþ";
            string runes = "ᛅᛅᛒᛋᛏᚦᛁᛁᚠᚴᚼᛁᛁᛁᚴᛚᛘᚾᚢᚢᛒᚴᚱᛋᛏᚦᚢᚢᚢᚢᛋᚢᚢᛋᚢᛅᛅᚢᚢᚢᚦ";

            YoungerFuthark youngerFuthark = new YoungerFuthark();
            string result = youngerFuthark.LettersToLongBranchRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsLettersToShortTwigRunes()
        {
            string letters = "aábcdðeéfghiíjklmnoópqrstþuúvwxyýzåäæöøǫþ";
            string runes = "ᛆᛆᛒᛌᛐᚦᛁᛁᚠᚴᚽᛁᛁᛁᚴᛚᛘᚿᚢᚢᛒᚴᚱᛌᛐᚦᚢᚢᚢᚢᛌᚢᚢᛌᚢᛆᛆᚢᚢᚢᚦ";

            YoungerFuthark youngerFuthark = new YoungerFuthark();
            string result = youngerFuthark.LettersToShortTwigRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsTextContentToYoungerFuthark()
        {
            // From Old Groms runestone.
            string letters = "auk tani karþi kristna";
            string runes = "ᛅᚢᚴ:ᛏᛅᚾᛁ:ᚴᛅᚱᚦᛁ:ᚴᚱᛁᛋᛏᚾᛅ";

            YoungerFuthark youngerFuthark = new YoungerFuthark();
            string result = youngerFuthark.LettersToRunes(letters);

            Assert.Equal(runes, result);
        }

        [Fact]
        public void TransformsRunesToLetters()
        {
            // Both long branch & short twig should produce same letters.
            string longBranchRunes = "ᚠᚢᚦᚬᚱᚴᚼᚽᚾᚿᛁᛅᛆᛋᛌᛏᛐᛒᛘᛚᛦ:";
            string shortTwigRunes = "ᚠᚢᚦᚬᚱᚴᚽᚽᚿᚿᛁᛆᛆᛌᛌᛐᛐᛒᛘᛚᛦ:";
            string letters = "fuþorkhhnniaassttbmlR ";

            YoungerFuthark youngerFuthark = new YoungerFuthark();
            string result1 = youngerFuthark.RunesToLetters(longBranchRunes);
            string result2 = youngerFuthark.RunesToLetters(shortTwigRunes);

            Assert.Equal(letters, result1);
            Assert.Equal(letters, result2);
        }

        [Fact]
        public void TransformsRuneContentToLatinLetters()
        {
            // From Old Groms runestone.
            string runes = "ᛅᚢᚴ:ᛏᛅᚾᛁ:ᚴᛅᚱᚦᛁ:ᚴᚱᛁᛋᛏᚾᛅ";
            string letters = "auk tani karþi kristna";

            YoungerFuthark youngerFuthark = new YoungerFuthark();
            string result = youngerFuthark.RunesToLetters(runes);

            Assert.Equal(letters, result);
        }

        [Fact]
        public void StyleVariantSettersChangeRuneset()
        {
            string letters = "aábcdðeéfghiíjklmnoópqrstþuúvwxyýzåäæöøǫþ";
            string expectedLongBranchRunes = "ᛅᛅᛒᛋᛏᚦᛁᛁᚠᚴᚼᛁᛁᛁᚴᛚᛘᚾᚢᚢᛒᚴᚱᛋᛏᚦᚢᚢᚢᚢᛋᚢᚢᛋᚢᛅᛅᚢᚢᚢᚦ";
            string expectedShortTwigRunes = "ᛆᛆᛒᛌᛐᚦᛁᛁᚠᚴᚽᛁᛁᛁᚴᛚᛘᚿᚢᚢᛒᚴᚱᛌᛐᚦᚢᚢᚢᚢᛌᚢᚢᛌᚢᛆᛆᚢᚢᚢᚦ";

            YoungerFuthark youngerFuthark = new YoungerFuthark();

            // Expected to use long branch as default.
            string longBranchResult = youngerFuthark.LettersToRunes(letters);

            // Change to short twig.
            youngerFuthark.EnableShortTwig();
            string shortTwigResult = youngerFuthark.LettersToRunes(letters);

            // Switch back to long branch
            youngerFuthark.EnableLongBranch();
            string secondLongBranchResult = youngerFuthark.LettersToRunes(letters);

            Assert.Equal(expectedLongBranchRunes, longBranchResult);
            Assert.Equal(expectedShortTwigRunes, shortTwigResult);
            Assert.Equal(expectedLongBranchRunes, secondLongBranchResult);
        }

        [Fact]
        public void ConstructorsDefineRuneSetToUse()
        {
            string letters = "aábcdðeéfghiíjklmnoópqrstþuúvwxyýzåäæöøǫþ";
            string expectedLongBranchRunes = "ᛅᛅᛒᛋᛏᚦᛁᛁᚠᚴᚼᛁᛁᛁᚴᛚᛘᚾᚢᚢᛒᚴᚱᛋᛏᚦᚢᚢᚢᚢᛋᚢᚢᛋᚢᛅᛅᚢᚢᚢᚦ";
            string expectedShortTwigRunes = "ᛆᛆᛒᛌᛐᚦᛁᛁᚠᚴᚽᛁᛁᛁᚴᛚᛘᚿᚢᚢᛒᚴᚱᛌᛐᚦᚢᚢᚢᚢᛌᚢᚢᛌᚢᛆᛆᚢᚢᚢᚦ";

            YoungerFuthark youngerFutharkDefault = new YoungerFuthark();
            YoungerFuthark youngerFutharkLongBranch = new YoungerFuthark(YoungerFuthark.Variant.LongBranch);
            YoungerFuthark youngerFutharkShortTwig = new YoungerFuthark(YoungerFuthark.Variant.ShortTwig);

            string defaultResult = youngerFutharkDefault.LettersToRunes(letters);
            string shortTwigResult = youngerFutharkShortTwig.LettersToRunes(letters);
            string longBranchResult = youngerFutharkLongBranch.LettersToRunes(letters);

            Assert.Equal(expectedLongBranchRunes, defaultResult);
            Assert.Equal(expectedShortTwigRunes, shortTwigResult);
            Assert.Equal(expectedLongBranchRunes, longBranchResult);
        }
    }
}
