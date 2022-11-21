using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_and_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Break();
            Continue();
            SkipOddNumbers();
            SkipEvenNumbers();

            Console.Read();
        }

        static void Break()
        {
            for (int count = 0; count < 10; count++)
            {
                if (count == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }

                Console.WriteLine(count);
            }
        }

        static void Continue()
        {
            for (int count = 0; count < 10; count++)
            {
                if (count == 7)
                {
                    Console.WriteLine("Skipped no 7!");
                    continue;
                }

                Console.WriteLine(count);
            }
        }

        static void SkipOddNumbers()
        {
            for (int count = 0; count < 10; count++)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine("Skipped even number!");
                    continue;
                }

                Console.WriteLine(count);
            }
        }
        static void SkipEvenNumbers()
        {
            for (int count = 0; count < 10; count++)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine("Skipped odd number!");
                    continue;
                }

                Console.WriteLine(count);
            }
        }
    }
}
