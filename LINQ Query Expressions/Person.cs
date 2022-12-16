using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Query_Expressions
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public static List<Person> GetAllPeople() 
        {
            List<Person> people = new List<Person>();

            Person person_one = new Person(1, "Raj", 35);
            people.Add(person_one);

            Person person_two = new Person(2, "Sham", 34);
            people.Add(person_two);

            Person person_three = new Person(3, "Axa", 4);
            people.Add(person_three);

            return people;

        }
    }
}
