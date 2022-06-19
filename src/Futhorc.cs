using System;
using System.Collections.Generic;
using Riimut.Mappings;

namespace Riimut
{
    public class Futhorc : Dialect
    {
        public string LettersToRunes(string content)
        {
            Dictionary<string, string> mapping = FuthorcMapping.GetLettersToRunesDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }

        public string RunesToLetters(string content)
        {
            Dictionary<string, string> mapping = FuthorcMapping.GetRunesToLettersDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }
    }
}
