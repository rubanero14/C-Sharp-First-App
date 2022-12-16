using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method for String type
            string name = "rajaruban";

            var formattedNameOne = Helper.ChangeFirstCharToLowerOrUpper(name); // Helper method without static keyword, passing string as args
            Console.WriteLine(formattedNameOne);

            var formattedNameTwo = name.ChangeFirstCharToLowerOrUpper(); // Helper method becomes an Extension Method just by appending to the string, not by passing as args
            Console.WriteLine(formattedNameTwo);

            // MethodAccessException for List<int> type
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // List of Numbers

            // Using built-in Enumerable extension class method with LINQ Lambda Expression by passing 2 args, first param is List of numbers, second is Lambda Expression
            IEnumerable<int> evenNumbersOne = Enumerable.Where(Numbers, x => x % 2 == 0);
            foreach (int number in evenNumbersOne)
            {
                Console.WriteLine(number);
            }

            List<int> evenNumbersTwo = Helper.EvenNumbers(Numbers); // Helper method without static keyword, passing List<int> as args

            // Since this is List type, we have to use foreach method to print to console
            foreach (var num in evenNumbersTwo)
            {
                Console.WriteLine(num);
            }

            // Since this is List type, we have to use foreach method to print to console
            List<int> evenNumberThree = Numbers.EvenNumbers();  // Helper method becomes an Extension Method just by appending to the List<int>, not by passing as args
            foreach (var num in evenNumberThree)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
