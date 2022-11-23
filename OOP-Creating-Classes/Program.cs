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
            Human raj = new Human("Raj", "Ruban");
            raj.IntroMyself();
            Human sharm = new Human("Guga", "Sharm");
            sharm.IntroMyself();

            // Excercise

            
            Console.Read();
        }
    }
}
