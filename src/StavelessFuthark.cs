using System.Collections.Generic;
using Riimut.Mappings;

namespace Riimut
{
    public class StavelessFuthark : Dialect
    {
        public string LettersToRunes(string content)
        {
            Dictionary<string, string> mapping = StavelessFutharkMapping.GetLettersToRunesDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }

        public string RunesToLetters(string content)
        {
            Dictionary<string, string> mapping = StavelessFutharkMapping.GetRunesToLettersDictionary();

            return Riimut.Transform.WithDictionary(content, mapping);
        }
    }
}
