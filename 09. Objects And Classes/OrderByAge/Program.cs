using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (inputArgs[0] == "End")
                {
                    break;
                }

                string personName = inputArgs[0];
                string personId = inputArgs[1];
                int personAge = int.Parse(inputArgs[2]);

                Person person = new Person(personName, personId, personAge);
                people.Add(person);
            }

            people = people
                .OrderBy(p => p.Age)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }



        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }



        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
