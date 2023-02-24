using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSDOTNET
{
    public static class StringExtensions
    {
        public static string SnakeCase(this string str, char replacement = '_')
        {
            return str.Replace(' ', replacement).ToLower();
        }

        public static string FullTrim(this string str)
        {
            str = str.Trim();
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] == ' ')
                {
                    if (str[i + 1] == ' ')
                    {
                        str = str.Remove(i);
                    }
                }
            }

            return str;
        }
    }
}
