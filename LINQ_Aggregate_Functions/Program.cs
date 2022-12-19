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
            // Initiating array of integers 1 - 10
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Initiating array of strings with country names
            string[] Countries = { "Malaysia", "Singapore", "USA", "India" };

            // Without LINQ, using custome extension method class
            int minNoLINQ = Numbers.MinNoLINQ();
            int maxNoLINQ = Numbers.MaxNoLINQ();

            int smallestEvenNumNoLINQ = Numbers.SmallestEvenNumNoLINQ();
            int largestEvenNumNoLINQ = Numbers.LargestEvenNumNoLINQ();

            int smallestOddNumNoLINQ = Numbers.SmallestOddNumNoLINQ();
            int largestOddNumNoLINQ = Numbers.LargestOddNumNoLINQ();

            int sumOfAllNumbersNoLINQ = Numbers.SumOfAllNumsNoLINQ();
            int sumOfAllEvenNumbersNoLINQ = Numbers.Where(x => x % 2 == 0).Sum();
            int sumOfAllOddNumbersNoLINQ = Numbers.Where(x => x % 2 == 1).Sum();

            int countOfAllNumbersNoLINQ = Numbers.CountOfAllNumsNoLINQ();
            int countOfAllEvenNumbersNoLINQ = Numbers.CountOfAllEvenNumsNoLINQ();
            int countOfAllOddNumbersNoLINQ = Numbers.CountOfAllOddNumsNoLINQ();

            double averageOfAllNumbersNoLINQ = Numbers.AverageOfAllNumsNoLINQ();
            double averageOfAllEvenNumbersNoLINQ = Numbers.AverageOfAllEvenNumsNoLINQ();
            double averageOfAllOddNumbersNoLINQ = Numbers.AverageOfAllOddNumsNoLINQ();

            int lengthOfShortestCountryNameNoLINQ = Countries.MinLengthCountryNameNoLINQ();
            int lengthOfLongestCountryNameNoLINQ = Countries.MaxLengthCountryNameNoLINQ();

            Console.WriteLine($"Examples of operation using without LINQ, using custom extension method class:");
            Console.WriteLine($"Min No LINQ: {minNoLINQ}");
            Console.WriteLine($"Max No LINQ: {maxNoLINQ}\n");

            Console.WriteLine($"Smallest Even Num No LINQ: {smallestEvenNumNoLINQ}");
            Console.WriteLine($"Largest Even Num No LINQ: {largestEvenNumNoLINQ}\n");

            Console.WriteLine($"Smallest Odd Num No LINQ: {smallestOddNumNoLINQ}");
            Console.WriteLine($"Largest Odd Num No LINQ: {largestOddNumNoLINQ}\n");

            Console.WriteLine($"Sum of all Nums No LINQ: {sumOfAllNumbersNoLINQ}");
            Console.WriteLine($"Sum of all Even Nums No LINQ: {sumOfAllEvenNumbersNoLINQ}");
            Console.WriteLine($"Sum of all Odd Nums No LINQ: {sumOfAllOddNumbersNoLINQ}\n");

            Console.WriteLine($"Count of all Nums No LINQ: {countOfAllNumbersNoLINQ}");
            Console.WriteLine($"Count of all Even Nums No LINQ: {countOfAllEvenNumbersNoLINQ}");
            Console.WriteLine($"Count of all Odd Nums No LINQ: {countOfAllOddNumbersNoLINQ}\n");

            Console.WriteLine($"Average of all Nums No LINQ: {averageOfAllNumbersNoLINQ}");
            Console.WriteLine($"Average of all Even Nums No LINQ: {averageOfAllEvenNumbersNoLINQ}");
            Console.WriteLine($"Average of all Odd Nums No LINQ: {averageOfAllOddNumbersNoLINQ}\n");

            Console.WriteLine($"Length of Shortest Country Name No LINQ: {lengthOfShortestCountryNameNoLINQ}");
            Console.WriteLine($"Length of Longest Country Name No LINQ: {lengthOfLongestCountryNameNoLINQ}\n");

            // With LINQ based Aggregate Functions
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

            Console.WriteLine($"Examples of operations using LINQ Aggregate Functions, ie: .Sum(), .Min(), .Max(), .Count() and etc:");

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
