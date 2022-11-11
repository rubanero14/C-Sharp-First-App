using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Switch_Case_Statements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int age = 35;

            // Switch statement
            switch (age)
            {
                case 15:
                    Console.WriteLine("Teenager");
                    break;
                case 25:
                    Console.WriteLine("Young Adult");
                    break;
                 case 35:
                    Console.WriteLine("Adult");
                    break;
                default:
                    Console.WriteLine("Whats your age?");
                    break;
            }

            // Exercise: Convert switch to if statement
            if (age == 15)
            {
                Console.WriteLine("Teenager");
            } 
            else if(age == 25)
            {
                Console.WriteLine("Young Adult");
            }
            else if (age == 35)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Whats your age?");
            }

            string userName = "raj";

            switch (userName)
            {
                case "raj":
                    Console.WriteLine("Hello {0}", userName);
                    break;
                default:
                    Console.WriteLine("Who are you?");
                    break;
            }

            Console.ReadKey();
        }
    }
}
