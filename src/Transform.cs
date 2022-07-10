using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Riimut.Mappings;

namespace Riimut
{
    public class Transform
    {
        public static string WithDictionary(string content, Dictionary<string, string> dictionary)
        {
            StringBuilder result = new StringBuilder();

            foreach (char letter in content)
            {
                string unmodified = letter.ToString();
                string lower = Char.ToLower(letter).ToString();
                if (dictionary.ContainsKey(unmodified))
                {
                    result.Append(dictionary[unmodified]);
                }
                else if (dictionary.ContainsKey(lower))
                    result.Append(dictionary[lower]);
                else
                {
                    result.Append(unmodified);
                }
            }

            return result.ToString();
        }
    }
}
