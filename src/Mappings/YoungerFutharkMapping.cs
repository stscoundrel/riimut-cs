using System;
using System.Collections.Generic;

namespace Riimut.Mappings
{
    internal class YoungerFutharkMapping
    {
        private readonly static Dictionary<string, string> LettersToLongBranchRunesMapping = new Dictionary<string, string>()
            {
                {"a", "ᛅ"},
                {"á", "ᛅ"},
                {"b", "ᛒ"},
                {"c", "ᛋ"},
                {"d", "ᛏ"},
                {"ð", "ᚦ"},
                {"e", "ᛁ"},
                {"é", "ᛁ"},
                {"f", "ᚠ"},
                {"g", "ᚴ"},
                {"h", "ᚼ"},
                {"i", "ᛁ"},
                {"í", "ᛁ"},
                {"j", "ᛁ"},
                {"k", "ᚴ"},
                {"l", "ᛚ"},
                {"m", "ᛘ"},
                {"n", "ᚾ"},
                {"o", "ᚢ"},
                {"ó", "ᚢ"},
                {"p", "ᛒ"},
                {"q", "ᚴ"},
                {"r", "ᚱ"},
                {"s", "ᛋ"},
                {"t", "ᛏ"},
                {"þ", "ᚦ"},
                {"u", "ᚢ"},
                {"ú", "ᚢ"},
                {"v", "ᚢ"},
                {"w", "ᚢ"},
                {"x", "ᛋ"},
                {"y", "ᚢ"},
                {"ý", "ᚢ"},
                {"z", "ᛋ"},
                {"å", "ᚢ"},
                {"ä", "ᛅ"},
                {"æ", "ᛅ"},
                {"œ", "ᚢ"},
                {"ö", "ᚢ"},
                {"ø", "ᚢ"},
                {"ǫ", "ᚢ"},
                {" ", ":"},
            };


        private readonly static Dictionary<string, string> LettersToShortTwigRunesMapping = new Dictionary<string, string>()
            {
                {"a", "ᛆ"},
                {"á", "ᛆ"},
                {"b", "ᛒ"},
                {"c", "ᛌ"},
                {"d", "ᛐ"},
                {"ð", "ᚦ"},
                {"e", "ᛁ"},
                {"é", "ᛁ"},
                {"f", "ᚠ"},
                {"g", "ᚴ"},
                {"h", "ᚽ"},
                {"i", "ᛁ"},
                {"í", "ᛁ"},
                {"j", "ᛁ"},
                {"k", "ᚴ"},
                {"l", "ᛚ"},
                {"m", "ᛘ"},
                {"n", "ᚿ"},
                {"o", "ᚢ"},
                {"ó", "ᚢ"},
                {"p", "ᛒ"},
                {"q", "ᚴ"},
                {"r", "ᚱ"},
                {"s", "ᛌ"},
                {"t", "ᛐ"},
                {"þ", "ᚦ"},
                {"u", "ᚢ"},
                {"ú", "ᚢ"},
                {"v", "ᚢ"},
                {"w", "ᚢ"},
                {"x", "ᛌ"},
                {"y", "ᚢ"},
                {"ý", "ᚢ"},
                {"z", "ᛌ"},
                {"å", "ᚢ"},
                {"ä", "ᛆ"},
                {"æ", "ᛆ"},
                {"œ", "ᚢ"},
                {"ö", "ᚢ"},
                {"ø", "ᚢ"},
                {"ǫ", "ᚢ"},
                {" ", ":"},
            };

        private readonly static Dictionary<string, string> RunesToLettersMapping = new Dictionary<string, string>()
            {
                {"ᚠ", "f"},
                {"ᚢ", "u"},
                {"ᚦ", "þ"},
                {"ᚬ", "o"},
                {"ᚱ", "r"},
                {"ᚴ", "k"},
                {"ᚼ", "h"},
                {"ᚽ", "h"},
                {"ᚾ", "n"},
                {"ᚿ", "n"},
                {"ᛁ", "i"},
                {"ᛅ", "a"},
                {"ᛆ", "a"},
                {"ᛋ", "s"},
                {"ᛌ", "s"},
                {"ᛏ", "t"},
                {"ᛐ", "t"},
                {"ᛒ", "b"},
                {"ᛘ", "m"},
                {"ᛚ", "l"},
                {"ᛦ", "R"},
                {":", " "},
            };
        public static Dictionary<string, string> GetLettersToLongBranchRunesDictionary()
        {
            return LettersToLongBranchRunesMapping;
        }

        public static Dictionary<string, string> GetLettersToShortTwigRunesDictionary()
        {
            return LettersToShortTwigRunesMapping;
        }

        public static Dictionary<string, string> GetRunesToLettersDictionary()
        {
            return RunesToLettersMapping;
        }
    }
}
