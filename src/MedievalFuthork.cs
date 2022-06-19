using System;
using System.Collections.Generic;
using Riimut.Mappings;

namespace Riimut
{
    public class MedievalFuthork : Dialect
    {
        public string LettersToRunes(string content)
        {
            Dictionary<string, string> mapping = MedievalFuthorkMapping.GetLettersToRunesDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }

        public string RunesToLetters(string content)
        {
            Dictionary<string, string> mapping = MedievalFuthorkMapping.GetRunesToLettersDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }
    }
}
