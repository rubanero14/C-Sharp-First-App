using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Creating_Classes
{
    // this class is a blueprint for a data type
    class Human
    {
        // member variable, remove keyword public or change to private to avoid external classes changing its value
        public string firstName;
        public string lastName;
        
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // member
        public void IntroMyself()
        {
            Console.WriteLine($"Hi, my name is {firstName} {lastName}");
        }
    }
}
