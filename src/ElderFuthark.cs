using System;
using System.Collections.Generic;
using Riimut.Mappings;

namespace Riimut
{
    public class ElderFuthark
    {
        public static string LettersToRunes(string content)
        {
            Dictionary<string, string> mapping = ElderFutharkMapping.GetLettersToRunesDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }

        public static string RunesToLetters(string content)
        {
            Dictionary<string, string> mapping = ElderFutharkMapping.GetRunesToLettersDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }
    }
}
