using System.Collections.Generic;
using Riimut.Mappings;

namespace Riimut
{
    public class YoungerFuthark : Dialect
    {
        public enum Variant
        {
            LongBranch,
            ShortTwig
        }

        Variant RuneStyle;

        public YoungerFuthark(Variant style = Variant.LongBranch)
        {
            RuneStyle = style;
        }

        public void EnableLongBranch()
        {
            RuneStyle = Variant.LongBranch;
        }

        public void EnableShortTwig()
        {
            RuneStyle = Variant.ShortTwig;
        }

        public string LettersToRunes(string content)
        {
            Dictionary<string, string> mapping = RuneStyle == Variant.LongBranch ? YoungerFutharkMapping.GetLettersToLongBranchRunesDictionary() : YoungerFutharkMapping.GetLettersToShortTwigRunesDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }

        public string RunesToLetters(string content)
        {
            Dictionary<string, string> mapping = YoungerFutharkMapping.GetRunesToLettersDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }

        public string LettersToLongBranchRunes(string content)
        {
            Dictionary<string, string> mapping = YoungerFutharkMapping.GetLettersToLongBranchRunesDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }

        public string LettersToShortTwigRunes(string content)
        {
            Dictionary<string, string> mapping = YoungerFutharkMapping.GetLettersToShortTwigRunesDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }
    }
}
