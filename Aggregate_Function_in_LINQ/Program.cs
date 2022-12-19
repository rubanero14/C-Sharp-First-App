using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Function_in_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Countries = { "Malaysia", "Singapore", "Indonesia", "Thailand", "India", "Australia", "New Zealand", "USA" };

            // Without LINQ Aggregate Function, using custom extension method class
            string stringOfCountriesNoLINQ = Countries.Stringify();
            Console.WriteLine($"Stringified List from Array without LINQ: {stringOfCountriesNoLINQ}\n");

            // With LINQ Aggregate Function


            Console.ReadLine();
        }
    }
}
