using System;
using System.Collections.Generic;
using System.Linq;

namespace Students3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                string firstName = studentArgs[0];
                string lastName = studentArgs[1];
                double grade = double.Parse(studentArgs[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            students = students
                .OrderByDescending(s => s.Grade)
                .ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}: {s.Grade:f2}");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }



        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }
}
