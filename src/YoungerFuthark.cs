using System;
using System.Collections.Generic;
using Riimut.Mappings;

namespace Riimut
{
    public class YoungerFuthark : Dialect
    {
        public string LettersToRunes(string content)
        {
            Dictionary<string, string> mapping = YoungerFutharkMapping.GetLettersToRunesDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }

        public string RunesToLetters(string content)
        {
            Dictionary<string, string> mapping = YoungerFutharkMapping.GetRunesToLettersDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }
    }
}
