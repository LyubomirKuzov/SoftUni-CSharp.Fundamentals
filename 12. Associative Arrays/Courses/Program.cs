using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(" : ")
                    .ToArray();

                if (inputArgs[0] == "end")
                {
                    break;
                }

                string courseName = inputArgs[0];
                string studentName = inputArgs[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(studentName);
            }

            courses = courses
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
