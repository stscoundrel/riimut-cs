using System;
using System.Collections.Generic;

namespace Riimut.Mappings
{
    public class FuthorcMapping
    {
        public static Dictionary<string, string> GetLettersToRunesDictionary()
        {
            return new Dictionary<string, string>()
            {
                {"a", "ᚪ"},
                {"á", "ᚪ"},
                {"b", "ᛒ"},
                {"c", "ᚳ"},
                {"d", "ᛞ"},
                {"ð", "ᛞ"},
                {"e", "ᛖ"},
                {"é", "ᛖ"},
                {"f", "ᚠ"},
                {"g", "ᚷ"},
                {"h", "ᚻ"},
                {"i", "ᛁ"},
                {"í", "ᛇ"},
                {"ï", "ᛇ"},
                {"ʒ", "ᛇ"},
                {"j", "ᛡ"},
                {"k", "ᚳ"},
                {"l", "ᛚ"},
                {"m", "ᛗ"},
                {"n", "ᚾ"},
                {"ŋ", "ᛝ"},
                {"o", "ᚩ"},
                {"ó", "ᚩ"},
                {"ǫ", "ᚩ"},
                {"p", "ᛈ"},
                {"q", "ᚳ"},
                {"r", "ᚱ"},
                {"s", "ᛋ"},
                {"t", "ᛏ"},
                {"u", "ᚢ"},
                {"ú", "ᚢ"},
                {"v", "ᚹ"},
                {"w", "ᚹ"},
                {"x", "ᛉ"},
                {"y", "ᚣ"},
                {"ý", "ᚣ"},
                {"z", "ᛉ"},
                {"å", "ᚩ"},
                {"ä", "ᚫ"},
                {"æ", "ᚫ"},
                {"œ", "ᛟ"},
                {"ö", "ᛟ"},
                {"ø", "ᛟ"},
                {"þ", "ᚦ"},
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
                {"ᚩ", "o"},
                {"ᚱ", "r"},
                {"ᚳ", "c"},
                {"ᚷ", "g"},
                {"ᚹ", "w"},
                {"ᚻ", "h"},
                {"ᚾ", "n"},
                {"ᛁ", "i"},
                {"ᛡ", "j"},
                {"ᛄ", "j"},
                {"ᛇ", "ï"},
                {"ᛈ", "p"},
                {"ᛉ", "x"},
                {"ᛋ", "s"},
                {"ᚴ", "s"},
                {"ᛏ", "t"},
                {"ᛒ", "b"},
                {"ᛖ", "e"},
                {"ᛗ", "m"},
                {"ᛚ", "l"},
                {"ᛝ", "ŋ"},
                {"ᛟ", "œ"},
                {"ᛞ", "d"},
                {"ᚪ", "a"},
                {"ᚫ", "æ"},
                {"ᚣ", "y"},
                {":", " "},
                {"ᛠ", "ea"},
            };
        }
    }
}
