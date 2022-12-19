using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Creating_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object of my class, also called an instance of Human class
            Human mickey = new Human("Mickey", "Mouse");
            mickey.IntroMyself();
            Human bambi = new Human("Bambi", "Deer");
            bambi.IntroMyself();

            Console.Read();
        }
    }
}
