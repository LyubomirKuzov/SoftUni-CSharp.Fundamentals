using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commandArgs[0];

                commandArgs = commandArgs
                    .Skip(1)
                    .ToArray();

                switch (command)
                {
                    case "course start":
                        Print(lessons);
                        return;

                    case "Add":
                        Add(lessons, commandArgs);
                        break;

                    case "Insert":
                        Insert(lessons, commandArgs);
                        break;

                    case "Remove":
                        Remove(lessons, commandArgs);
                        break;

                    case "Swap":
                        Swap(lessons, commandArgs);
                        break;

                    case "Exercise":
                        Exercise(lessons, commandArgs);
                        break;
                }
            }
        }

        public static void Add(List<string> lessons, string[] commandArgs)
        {
            string lessonTitle = commandArgs[0];

            if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
            }
        }

        public static void Insert(List<string> lessons, string[] commandArgs)
        {
            string lessonTitle = commandArgs[0];
            int index = int.Parse(commandArgs[1]);

            if (index >= 0 && index < lessons.Count && !lessons.Contains(lessonTitle))
            {
                lessons.Insert(index, lessonTitle);
            }
        }

        public static void Remove(List<string> lessons, string[] commandArgs)
        {
            string lessonTitle = commandArgs[0];

            if (lessons.Contains(lessonTitle))
            {
                lessons.Remove(lessonTitle);

                if (lessons.Contains(lessonTitle + "-Exercise"))
                {
                    lessons.Remove(lessonTitle + "-Exercise");
                }
            }
        }

        public static void Swap(List<string> lessons, string[] commandArgs)
        {
            string firstLessonTitle = commandArgs[0];
            string secondLessonTitle = commandArgs[1];

            if (lessons.Contains(firstLessonTitle) && lessons.Contains(secondLessonTitle))
            {
                int firstLessonIndex = lessons.IndexOf(firstLessonTitle);
                int secondLessonIndex = lessons.IndexOf(secondLessonTitle);

                string temp = firstLessonTitle;
                lessons[firstLessonIndex] = secondLessonTitle;
                lessons[secondLessonIndex] = temp;

                if (lessons.Contains(firstLessonTitle + "-Exercise"))
                {
                    lessons.RemoveAt(firstLessonIndex + 1);
                    lessons.Insert(secondLessonIndex + 1, firstLessonTitle + "-Exercise");
                }

                if (lessons.Contains(secondLessonTitle + "-Exercise"))
                {
                    lessons.RemoveAt(secondLessonIndex + 1);
                    lessons.Insert(firstLessonIndex + 1, secondLessonTitle + "-Exercise");
                }
            }
        }

        public static void Exercise(List<string> lessons, string[] commandArgs)
        {
            string lessonTitle = commandArgs[0];

            if (lessons.Contains(lessonTitle) && !lessons.Contains(lessonTitle + "-Exercise"))
            {
                int lessonIndex = lessons.IndexOf(lessonTitle);
                lessons.Insert(lessonIndex + 1, lessonTitle + "-Exercise");
            }

            else if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
                lessons.Add(lessonTitle + "-Exercise");
            }
        }

        public static void Print(List<string> lessons)
        {
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
