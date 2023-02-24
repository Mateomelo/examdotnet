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
                if (item % 2 == 0)
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

        public static List<TOutput> Transform<TInput, TOutput>( 
            this List<TInput> list, 
            Func<TInput, TOutput> predicate)
        {
            List<TOutput> res = new List<TOutput>();
            foreach (TInput item in list)
            {
                res.Add(predicate(item));
            }
            return res;
        }
    }
}
