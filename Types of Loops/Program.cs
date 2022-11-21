using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
            DoWhileLoop();
            WhileLoop();

            Console.ReadKey();
        }

        static void ForLoop()
        {
            // For Loop
            for (int counter = 0; counter < 50; counter += 5)
            {
                Console.WriteLine($"{counter} is lower than 50");
            }

            // For Loop Exercise to count odd numbers
            for (int counter = 1; counter < 20; counter += 2)
            {
                Console.WriteLine($"{counter} is an odd number!");
            }
            Console.WriteLine("Loop Exited!");
        }

        static void DoWhileLoop()
        {
            // Do While Loop
            int counter = 0;
            Console.Write("Enter max number of counter: ");
            int userSetCounter = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{counter} is below {userSetCounter}");
                counter++;
            } while (counter < userSetCounter);

            // User input word length reader
            int lengthOfText = 0;
            string wholeWord = "";
            do 
            {
                Console.Write("Please enter a word: ");
                string word = Console.ReadLine();
                int wordLength = word.Length;
                lengthOfText += wordLength;
                wholeWord += word;
                string forwattedWord = "";
                if (lengthOfText > 20)
                {
                    forwattedWord = wholeWord.Remove(20);
                }
                Console.WriteLine($"Current total word length inputted: {lengthOfText}");
                Console.WriteLine($"Current total word inputted: {(lengthOfText > 20 ? forwattedWord : wholeWord )}");
            }
            while (lengthOfText < 20);

            Console.WriteLine("Loop Exited!");
        }

        static void WhileLoop()
        {
            int counter = 0;
            while (counter < 20)
            {
                Console.WriteLine($"Current counter is {counter}");
                counter++;
            }
            Console.WriteLine("Loop Exited!");

            int peopleCount = 0;
            string peopleName = "";
            string totalPeople = "";
            Console.WriteLine("This program tracks and checks passenger count and names before bus is ready to go!");

            while (peopleCount < 10)
            {
                Console.Write("Enter passenger name: ");
                peopleName = Console.ReadLine();

                if (!peopleName.Equals(""))
                {
                    totalPeople = totalPeople == "" ? peopleName : (totalPeople + ", " + peopleName);
                    peopleCount++;
                    Console.WriteLine($"Passengers name who checked in: {totalPeople}");
                    Console.WriteLine($"Total Passengers checked in: {peopleCount}");
                }
                else
                {
                    Console.WriteLine("Please Enter Valid passenger name!");
                    Console.Write("Enter passenger name: ");
                    peopleName = Console.ReadLine();
                }
            }

            Console.WriteLine($"{peopleCount} passengers are in the bus, good to go!");
        }
    }
}
