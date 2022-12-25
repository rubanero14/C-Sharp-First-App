using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unary_Operator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c;

            // Unary operator
            c = -a;
            Console.WriteLine("c is {0}", c);

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            // Increment operators
            int d = 0;
            d++;
            Console.WriteLine("d is {0}", d);
            Console.WriteLine("d++ is {0}", d++);
            Console.WriteLine("++d is {0}", ++d);

            // Decrement operators
            int e = 0;
            e--;
            Console.WriteLine("d is {0}", e);
            Console.WriteLine("d-- is {0}", e--);
            Console.WriteLine("--d is {0}", --e);


            // Basic Operations
            int result;
            result = a + b;
            Console.WriteLine("result of a + b is {0}", result);
            result = a - b;
            Console.WriteLine("result of a - b is {0}", result);
            result = a * b;
            Console.WriteLine("result of a * b is {0}", result);
            result = a / b;
            Console.WriteLine("result of a / b is {0}", result);
            result = a % b;
            Console.WriteLine("result of a % b is {0}", result);

            // Relational and type operator
            bool isLower;
            isLower = a < b;
            Console.WriteLine("Result of a < b is {0}", isLower);

            // Equality operator
            bool isEqual;
            isEqual = a == b;
            Console.WriteLine("Result of a == b is {0}", isEqual);
            isEqual = a != b;
            Console.WriteLine("Result of a != b is {0}", isEqual);

            // Conditional operators
            bool isLowerAndSunny;
            bool isLowerOrSunny;

            // Condition1 AND Condition2
            isLowerOrSunny = isLower && isSunny;
            Console.WriteLine("Result of isLower && isSunny is {0}", isLowerOrSunny);

            // Condition1 OR Condition2
            isLowerOrSunny = isLower || isSunny;
            Console.WriteLine("Result of isLower || isSunny is {0}", isLowerOrSunny);

            Console.ReadKey();
        }
    }
}
