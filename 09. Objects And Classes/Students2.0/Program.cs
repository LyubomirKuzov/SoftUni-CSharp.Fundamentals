using System;
using System.Collections.Generic;
using System.Linq;

namespace Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string[] studentArgs = Console.ReadLine().Split().ToArray();

                if (studentArgs[0] == "end")
                {
                    break;
                }

                string firstName = studentArgs[0];
                string lastName = studentArgs[1];
                int age = int.Parse(studentArgs[2]);
                string homeTown = studentArgs[3];

                if (students.Any(s => s.FirstName == firstName && s.LastName == lastName))
                {
                    Student student = students.First(s => s.FirstName == firstName && s.LastName == lastName);

                    student.Age = age;
                    student.HomeTown = homeTown;
                }

                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    };

                    students.Add(student);
                }
            }

            string cityName = Console.ReadLine();

            students = students.Where(s => s.HomeTown == cityName).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string HomeTown { get; set; }
        }
    }
}
