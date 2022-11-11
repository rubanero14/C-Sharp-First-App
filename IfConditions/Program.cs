using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfConditions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int temp = 1;

            if(temp < 10)
            {
                Console.WriteLine("Take the coat!");
            }
            else if (temp == 10) {
                Console.WriteLine("It's 10 degrees Celcius");
            }
            else
            {
                Console.WriteLine("Cozy and Warm!");
            }

            // Exercise with user input
            Console.WriteLine("Whats the temperature like today?");
            int temp1 = int.Parse(Console.ReadLine());

            if (temp1 < 27)
            {
                Console.WriteLine("Wear a warm coat!");
            }
            else if (temp1 == 27)
            {
                Console.WriteLine("It's 27 degrees Celcius out there, room temprature");
            }
            else
            {
                Console.WriteLine("Freaking hot, wear shorts and singlets and wear sunc screen!");
            }

            Console.ReadKey();
        }
    }
}
