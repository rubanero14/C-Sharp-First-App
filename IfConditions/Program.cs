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
            bool isAdmin = false;
            bool isRegistered = true;
            string userName;

            Console.Write("Enter your username: ");
            userName = Console.ReadLine();

            // Nested If Statements
            if (isRegistered)
            {
                if (userName != string.Empty)
                {
                    if (userName.Equals("admin"))
                    {
                        isAdmin = true;
                        Console.WriteLine("Hi there {0}!", userName);
                    } else
                    {
                        Console.WriteLine("Hi there {0}!", userName);
                    }
                }
            }
            else
            {
                Console.WriteLine("User not registered!");
            }

            // Refactored If statement as above
            if (isRegistered && userName != string.Empty)
            {
                if (userName.Equals("admin"))
                {
                    isAdmin = true;
                    Console.WriteLine("Hi there {0}!", userName);
                } else
                {
                    Console.WriteLine("Hi there {0}!", userName);
                }
            }
            else
            {
                Console.WriteLine("User not registered!");
            }

            if(userName != string.Empty && (isAdmin || isRegistered))
            {
                Console.WriteLine("You are logged in as {0}!", userName);
            } else
            {
                Console.WriteLine("Please register unsername!");
            }

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
            string temp1 = Console.ReadLine();
            int parsedTemp;
            int newNum;
            bool success;

            // Using TryParse method to type conversion and error handling
            if (int.TryParse(temp1, out parsedTemp)){
                success = int.TryParse(temp1, out parsedTemp);
                newNum = parsedTemp;
                Console.WriteLine("Parsing successful, temperature is: {0}", newNum);
                Console.WriteLine("Type of parsedTemp {0}", newNum.GetTypeCode());
            } else
            {
                success = int.TryParse(temp1, out parsedTemp);
                Console.WriteLine("Parsing failed!");
            }

            if (success)
            {
                if (parsedTemp < 27)
                {
                    Console.WriteLine("Wear a warm coat!");
                }
                else if (parsedTemp == 27)
                {
                    Console.WriteLine("It's 27 degrees Celcius out there, room temprature");
                }
                else
                {
                    Console.WriteLine("Freaking hot, wear shorts and singlets and wear sunc screen!");
                }
            }
            Console.ReadKey();
        }
    }
}
