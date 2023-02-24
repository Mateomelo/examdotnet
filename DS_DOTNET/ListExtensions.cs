using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSDOTNET
{
    public static class ListExtensions
    {
        public static List<int> EvenValues(this List<int> list)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if(item % 2 == 0)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<int> OddValues(this List<int> list)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (item % 2 != 0)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<string> Transform(this List<string> list , Func<string, string> predicate)
        {
            List<string> res = new List<string>();
            list.ForEach(s =>
            {
                res.Add(predicate(s));
            });
            return res;
        }

        public static List<int> Transform(this List<int> list, Func<int, int> predicate)
        {
            List<int> res = new List<int>();
            list.ForEach(s =>
            {
                res.Add(predicate(s));
            });
            return res;
        }
    }
}
