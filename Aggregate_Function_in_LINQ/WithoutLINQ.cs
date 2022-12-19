using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Function_in_LINQ
{
    public static class WithoutLINQ
    {
        public static string Stringify(this string[] listItem)
        {
            string result = string.Empty;

            foreach (var item in listItem)
            {
                result = result + item + ", ";
            }
            return result;
        }
    }
}
