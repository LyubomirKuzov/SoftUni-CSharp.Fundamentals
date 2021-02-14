using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commandArgs[0] == "end")
                {
                    Console.WriteLine(string.Join(' ', numbers));
                    break;
                }

                string command = commandArgs[0];
                commandArgs = commandArgs.Skip(1).ToArray();

                switch (command)
                {
                    case "Add":
                        Add(numbers, int.Parse(commandArgs[0]));
                        break;

                    case "Remove":
                        Remove(numbers, int.Parse(commandArgs[0]));
                        break;

                    case "RemoveAt":
                        RemoveAt(numbers, int.Parse(commandArgs[0]));
                        break;

                    case "Insert":
                        Insert(numbers, int.Parse(commandArgs[0]), int.Parse(commandArgs[1]));
                        break;
                }
            }
        }

        public static void Add(List<int> list, int number)
        {
            list.Add(number);
        }

        public static void Remove(List<int> list, int number)
        {
            list.Remove(number);
        }

        public static void RemoveAt(List<int> list, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
        }

        public static void Insert(List<int> list, int number, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.Insert(index, number);
            }
        }
    }
}
