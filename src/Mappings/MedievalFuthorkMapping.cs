using System;
using System.Collections.Generic;

namespace Riimut.Mappings
{
    public class MedievalFuthorkMapping
    {
        public static Dictionary<string, string> GetLettersToRunesDictionary()
        {
            return new Dictionary<string, string>()
            {
                {"a", "ᛆ"},
                {"á", "ᛆ"},
                {"b", "ᛒ"},
                {"c", "ᚴ"},
                {"d", "ᚦ"},
                {"ð", "ᚦ"},
                {"e", "ᚽ"},
                {"é", "ᚽ"},
                {"f", "ᚠ"},
                {"g", "ᚵ"},
                {"h", "ᚼ"},
                {"i", "ᛁ"},
                {"í", "ᛁ"},
                {"j", "ᛁ"},
                {"k", "ᚴ"},
                {"l", "ᛚ"},
                {"m", "ᛘ"},
                {"n", "ᚿ"},
                {"o", "ᚮ"},
                {"ó", "ᚮ"},
                {"ǫ", "ᚰ"},
                {"p", "ᛕ"},
                {"q", "ᚴ"},
                {"r", "ᚱ"},
                {"s", "ᛋ"},
                {"t", "ᛏ"},
                {"u", "ᚢ"},
                {"ú", "ᚢ"},
                {"ü", "ᚢ"},
                {"v", "ᚠ"},
                {"w", "ᚠ"},
                {"x", "ᛋ"},
                {"y", "ᛦ"},
                {"ý", "ᛦ"},
                {"z", "ᛋ"},
                {"å", "ᚮ"},
                {"ä", "ᛅ"},
                {"æ", "ᛅ"},
                {"œ", "ᚯ"},
                {"ö", "ᚯ"},
                {"ø", "ᚯ"},
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
                {"ᚮ", "o"},
                {"ᚱ", "r"},
                {"ᚴ", "k"},
                {"ᚼ", "h"},
                {"ᚿ", "n"},
                {"ᛁ", "i"},
                {"ᛆ", "a"},
                {"ᛌ", "s"},
                {"ᛋ", "s"},
                {"ᛐ", "t"},
                {"ᛏ", "t"},
                {"ᛒ", "b"},
                {"ᛘ", "m"},
                {"ᛚ", "l"},
                {"ᛦ", "y"},
                {":", " "},

                // Sting diacritic secondary sounds.
                {"ᚯ", "ø"},
                {"ᛅ", "æ"},
                {"ᚰ", "ǫ"},
                {"ᛕ", "ᴘ"},
                {"ᚽ", "e"},
                {"ᚵ", "g"},
            };
        }
    }
}
