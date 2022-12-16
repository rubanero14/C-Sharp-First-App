using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lambda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Person> filteredPerson = Person.GetAllPeople()/*.Where(x => x.Id == 1)*/;

            Console.WriteLine("List of Person Registered:");

            foreach(var person in filteredPerson)
            {  
                Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Age: {person.Age}");
            }

            Console.ReadKey();
        }
    }
}
