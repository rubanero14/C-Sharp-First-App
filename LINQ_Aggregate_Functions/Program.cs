using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Aggregate_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instintiate array of integers 1 - 10
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Instintiate array of strings with country names
            string[] Countries = { "Malaysia", "Singapore", "USA", "India" };

            int min = Numbers.Min();
            int max = Numbers.Max();

            int smallestEvenNumber = Numbers.Where(x => x % 2 == 0).Min();
            int biggestEvenNumber = Numbers.Where(x => x % 2 == 0).Max();

            int smallestOddNumber = Numbers.Where(x => x % 2 == 1).Min();
            int biggestOddNumber = Numbers.Where(x => x % 2 == 1).Max();

            int sumOfAllNumbers = Numbers.Sum();
            int sumOfAllEvenNumbers = Numbers.Where(x => x % 2 == 0).Sum();
            int sumOfAllOddNumbers = Numbers.Where(x => x % 2 == 1).Sum();

            int countOfAllNumbers = Numbers.Count();
            int countOfAllEvenNumbers = Numbers.Where(x => x % 2 == 0).Count();
            int countOfAllOddNumbers = Numbers.Where(x => x % 2 == 1).Count();
            
            double averageOfAllNumbers = Numbers.Average(); // .Average() returns value type of double
            double averageOfAllEvenNumbers = Numbers.Where(x => x % 2 == 0).Average();
            double averageOfAllOddNumbers = Numbers.Where(x => x % 2 == 1).Average();

            int lengthOfShortestCountryName = Countries.Min(country => country.Length);
            int lengthOfLongestCountryName = Countries.Max(country => country.Length);

            Console.WriteLine($"Examples of operations using LINQ Aggregate Functions, ie: .Sum(), .Min(), .Max(), .Count() and etc. \n");

            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max} \n");

            Console.WriteLine($"Smallest Even Number: {smallestEvenNumber}");
            Console.WriteLine($"Biggest Even Number: {biggestEvenNumber} \n");

            Console.WriteLine($"Smallest Odd Number: {smallestOddNumber}");
            Console.WriteLine($"Biggest Odd Number: {biggestOddNumber} \n");

            Console.WriteLine($"Sum of all Numbers: {sumOfAllNumbers}");
            Console.WriteLine($"Sum of all Even Numbers: {sumOfAllEvenNumbers}");
            Console.WriteLine($"Sum of all Odd Numbers: {sumOfAllOddNumbers} \n");

            Console.WriteLine($"Count of all Numbers: {countOfAllNumbers}");
            Console.WriteLine($"Count of all Even Numbers: {countOfAllEvenNumbers}");
            Console.WriteLine($"Count of all Odd Numbers: {countOfAllOddNumbers}\n");

            Console.WriteLine($"Average of all Numbers: {averageOfAllNumbers}");
            Console.WriteLine($"Average of all Even Numbers: {averageOfAllEvenNumbers}");
            Console.WriteLine($"Average of all Odd Numbers: {averageOfAllOddNumbers}\n");

            Console.WriteLine($"Length of Shortest Country Name: {lengthOfShortestCountryName}");
            Console.WriteLine($"Length of Longest Country Name: {lengthOfLongestCountryName}\n");

            Console.ReadLine();
        }
    }
}
