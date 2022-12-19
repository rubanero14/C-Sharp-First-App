using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Function_in_LINQ
{
    public static class WithoutLINQ
    {
        public static string StringifyStringArray(this string[] listItem)
        {
            string result = string.Empty;

            foreach (var item in listItem)
            {
                result = result + item + ", ";
            }
            result = result.EndsWith(", ") ? result.Remove(result.Length - 2) : result;
            return result;
        }

        public static int ProductOfAllNumbers(this int[] listItem)
        {
            int result = 1;

            foreach (var item in listItem)
            {
                result *= item;
            }
            return result;
        }
    }
}
