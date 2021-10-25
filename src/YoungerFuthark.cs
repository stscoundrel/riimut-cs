using System;
using System.Collections.Generic;
using Riimut.Mappings;

namespace Riimut
{
    public class YoungerFuthark
    {
        public static string LettersToRunes(string content)
        {
            Dictionary<string, string> mapping = YoungerFutharkMapping.GetRunesToLettersDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }
    }
}
