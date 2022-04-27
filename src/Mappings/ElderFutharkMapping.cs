using System;
using System.Collections.Generic;

namespace Riimut.Mappings
{
    internal class ElderFutharkMapping
    {

        private readonly static Dictionary<string, string> LettersToRunesMapping = new Dictionary<string, string>()
            {
                {"a", "ᚨ"},
                {"á", "ᚨ"},
                {"b", "ᛒ"},
                {"c", "ᚲ"},
                {"d", "ᛞ"},
                {"ð", "ᚦ"},
                {"e", "ᛖ"},
                {"é", "ᛖ"},
                {"f", "ᚠ"},
                {"g", "ᚷ"},
                {"h", "ᚻ"},
                {"i", "ᛁ"},
                {"í", "ᛁ"},
                {"j", "ᛃ"},
                {"k", "ᚲ"},
                {"l", "ᛚ"},
                {"m", "ᛗ"},
                {"n", "ᚾ"},
                {"ŋ", "ᛜ"},
                {"o", "ᛟ"},
                {"ó", "ᛟ"},
                {"ǫ", "ᛟ"},
                {"p", "ᛈ"},
                {"q", "ᚲ"},
                {"r", "ᚱ"},
                {"s", "ᛋ"},
                {"t", "ᛏ"},
                {"u", "ᚢ"},
                {"ú", "ᚢ"},
                {"v", "ᚹ"},
                {"w", "ᚹ"},
                {"x", "ᛋ"},
                {"y", "ᛁ"},
                {"ý", "ᛁ"},
                {"z", "ᛉ"},
                {"å", "ᛟ"},
                {"ä", "ᛇ"},
                {"æ", "ᛇ"},
                {"ö", "ᚢ"},
                {"ø", "ᚢ"},
                {"þ", "ᚦ"},
                {" ", ":"},
            };

        private readonly static Dictionary<string, string> RunesToLettersMapping = new Dictionary<string, string>()
            {
                {"ᚠ", "f"},
                {"ᚢ", "u"},
                {"ᚦ", "þ"},
                {"ᚨ", "a"},
                {"ᚱ", "r"},
                {"ᚲ", "k"},
                {"ᚷ", "g"},
                {"ᚹ", "w"},
                {"ᚺ", "h"},
                {"ᚻ", "h"},
                {"ᚾ", "n"},
                {"ᛁ", "i"},
                {"ᛃ", "j"},
                {"ᛇ", "ï"},
                {"ᛈ", "p"},
                {"ᛉ", "z"},
                {"ᛊ", "s"},
                {"ᛋ", "s"},
                {"ᛏ", "t"},
                {"ᛒ", "b"},
                {"ᛖ", "e"},
                {"ᛗ", "m"},
                {"ᛚ", "l"},
                {"ᛜ", "ŋ"},
                {"ᛝ", "ŋ"},
                {"ᛟ", "o"},
                {"ᛞ", "d"},
                {":", " "},
            };
        public static Dictionary<string, string> GetLettersToRunesDictionary()
        {
            return LettersToRunesMapping;
        }

        public static Dictionary<string, string> GetRunesToLettersDictionary()
        {
            return RunesToLettersMapping;
        }
    }
}
