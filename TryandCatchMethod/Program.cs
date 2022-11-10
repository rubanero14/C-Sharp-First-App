using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryandCatchMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Addition Calculator Program");
            Console.Write("Please enter first num to be added: ");
            string input1 = Console.ReadLine();
            Console.Write("Please enter second num to be added: ");
            string input2 = Console.ReadLine();
            try
            {
                Addition(input1, input2);
                Console.WriteLine($"Result of addition is {Addition(input1, input2)}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Format Exception, please enter correct type next time!");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Overflow Exception, the number were too long or short for an Int32!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"Argument Null Exception, the value was empty(null)!");
            }
            finally
            {
                Console.WriteLine($"This is called anyways, end of code try catch block");
            }
            // Console.Read();
            Console.ReadLine();
        }
        public static double Addition(string a, string b)
        {
            return double.Parse(a) + double.Parse(b);
        }
    }
}
