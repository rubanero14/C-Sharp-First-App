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
            // Initiating string Array of Countries
            string[] Countries = { "Malaysia", "Singapore", "Indonesia", "Thailand", "India", "Australia", "New Zealand", "USA" };

            // Initiating int Array of Numbers
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Without LINQ Aggregate Function, using custom extension method class
            string stringOfCountriesNoLINQ = Countries.StringifyStringArray();
            int productOfAllNumbersNoLINQ = Numbers.ProductOfAllNumbers();

            Console.WriteLine($"Stringified string Array of Countries without LINQ:\n{stringOfCountriesNoLINQ}\n");
            Console.WriteLine($"Product of all Numbers in int Array without LINQ:\n{productOfAllNumbersNoLINQ}\n");

            // With LINQ Aggregate Function
            string stringOfCountries = Countries.Aggregate((a, b) => $"{a}, {b}");

            // Equivalent to .reduce() function in Javascript
            int productOfAllNumbers = Numbers.Aggregate((a, b) => a * b);

            // Seed parameter is a initial assigned value to variable a where Aggregate funtion will take as first param and second param is Lambda expression, where seed value will be the first variable
            int productOfAllNumbersWithSeedParam = Numbers.Aggregate(2, (a, b) => a * b); 

            Console.WriteLine($"Stringified string Array of Countries with LINQ Aggregate Function:\n{stringOfCountries}\n");
            Console.WriteLine($"Product of all Numbers in int Array with LINQ Aggregate Function:\n{productOfAllNumbers}\n");
            Console.WriteLine($"Product of all Numbers in int Array with LINQ Aggregate Function with Seed Parameter (Initial Value):\n{productOfAllNumbersWithSeedParam}\n");

            Console.ReadLine();
        }
    }
}
