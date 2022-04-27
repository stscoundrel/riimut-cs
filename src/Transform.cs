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
                string part = Char.ToLower(letter).ToString();
                if (dictionary.ContainsKey(part))
                {
                    result.Append(dictionary[part]);
                }
                else
                {
                    result.Append(part);
                }
            }

            return result.ToString();
        }
    }
}
