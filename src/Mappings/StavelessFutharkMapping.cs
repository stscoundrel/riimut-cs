using System.Collections.Generic;

namespace Riimut.Mappings
{
    internal class StavelessFutharkMapping
    {
        private readonly static Dictionary<string, string> LettersToRunesMapping = new Dictionary<string, string>()
            {
                {"a", "⸝"},
                {"á", "⸝"},
                {"b", "ˏ"},
                {"c", "╵"},
                {"d", "⸍"},
                {"ð", "ו"},
                {"e", "ᛁ"},
                {"é", "ᛁ"},
                {"f", "ᛙ"},
                {"g", "ᛍ"},
                {"h", "ᚽ"},
                {"i", "ᛁ"},
                {"í", "ᛁ"},
                {"j", "ᛁ"},
                {"k", "ᛍ"},
                {"l", "⸌"},
                {"m", "⠃"},
                {"n", "⸜"},
                {"o", "ˎ"},
                {"ó", "ˎ"},
                {"p", "ˏ"},
                {"q", "ᛍ"},
                {"r", "◟"},
                {"R", "⡄"},
                {"s", "╵"},
                {"t", "⸍"},
                {"þ", "ו"},
                {"u", "╮"},
                {"ú", "╮"},
                {"v", "╮"},
                {"w", "╮"},
                {"x", "╵"},
                {"y", "╮"},
                {"ý", "╮"},
                {"z", "╵"},
                {"å", "ˎ"},
                {"ä", "⸝"},
                {"æ", "⸝"},
                {"œ", "ˎ"},
                {"ö", "ˎ"},
                {"ø", "ˎ"},
                {"ǫ", "ˎ"},
                {" ", ":"},
            };

        private readonly static Dictionary<string, string> RunesToLettersMapping = new Dictionary<string, string>()
            {
                {"ᛙ", "f"},
                {"╮", "u"},
               {"ו", "þ"},
               {"ˎ", "o"},
               {"◟", "r"},
               {"ᛍ", "k"},
               {"ᚽ", "h"},
               {"⸜", "n"},
               {"ᛁ", "i"},
               {"⸝", "a"},
               {"╵", "s"},
               {"⸍", "t"},
               {"ˏ", "b"},
               {"⠃", "m"},
               {"⸌", "l"},
               {"⡄", "R"},
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
