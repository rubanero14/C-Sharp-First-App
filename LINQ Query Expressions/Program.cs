using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Query_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IEnumerable<Person> filteredPerson = from person in Person.GetAllPeople()
                                                where person.Id == 1
                                                select person;

            Console.WriteLine("List of Person Registered:");

            foreach (Person person in filteredPerson) {
                Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Age: {person.Age}");
            }
            Console.ReadKey();
        }
    }
}
