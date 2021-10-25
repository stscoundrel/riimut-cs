using System;
using System.Collections.Generic;
using Riimut.Mappings;

namespace Riimut
{
    public class YoungerFuthark
    {
        public static string LettersToRunes(string content)
        {
            Dictionary<string, string> mapping = YoungerFutharkMapping.GetLettersToRunesDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }

        public static string RunesToLetters(string content)
        {
            Dictionary<string, string> mapping = YoungerFutharkMapping.GetRunesToLettersDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }
    }
}
