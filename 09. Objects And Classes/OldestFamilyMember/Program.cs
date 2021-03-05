using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] personArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }

    public class Family
    {
        public Family()
        {
            this.Members = new List<Person>();
        }



        public List<Person> Members { get; set; }



        public void AddMember(Person person)
        {
            this.Members.Add(person);
        }

        public Person GetOldestMember()
        {
            return this.Members.First(m => m.Age == this.Members.Max(m => m.Age));
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }



        public string Name { get; set; }

        public int Age { get; set; }
    }
}
