using System;
using System.Collections.Generic;

namespace Riimut.Mappings
{
    public class YoungerFutharkMapping
    {
        public static Dictionary<string, string> GetLettersToRunesDictionary()
        {
            return new Dictionary<string, string>()
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
                {"ö", "ᚢ"},
                {"ø", "ᚢ"},
                {"ǫ", "ᚢ"},
                {" ", ":"},
            };
        }

        public static Dictionary<string, string> GetRunesToLettersDictionary()
        {
            return new Dictionary<string, string>()
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
        }
    }
}
