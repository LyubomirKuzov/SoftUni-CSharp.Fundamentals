using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool changesMade = false;

            while (true)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commandArgs[0] == "end")
                {
                    if (changesMade)
                    {
                        Console.WriteLine(string.Join(' ', numbers));
                    }

                    break;
                }

                string command = commandArgs[0];
                commandArgs = commandArgs.Skip(1).ToArray();

                switch (command)
                {
                    case "Add":
                        Add(numbers, int.Parse(commandArgs[0]));
                        changesMade = true;
                        break;

                    case "Remove":
                        Remove(numbers, int.Parse(commandArgs[0]));
                        changesMade = true;
                        break;

                    case "RemoveAt":
                        RemoveAt(numbers, int.Parse(commandArgs[0]));
                        changesMade = true;
                        break;

                    case "Insert":
                        Insert(numbers, int.Parse(commandArgs[0]), int.Parse(commandArgs[1]));
                        changesMade = true;
                        break;

                    case "Contains":
                        Contains(numbers, int.Parse(commandArgs[0]));
                        break;

                    case "PrintEven":
                        PrintEven(numbers);
                        break;

                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;

                    case "GetSum":
                        GetSum(numbers);
                        break;

                    case "Filter":
                        Filter(numbers, commandArgs[0], int.Parse(commandArgs[1]));
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

        public static void Contains(List<int> list, int number)
        {
            if (list.Contains(number))
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No such number");
            }
        }

        public static void PrintEven(List<int> list)
        {
            Console.WriteLine(string.Join(' ', list.Where(n => n % 2 == 0)));
        }

        public static void PrintOdd(List<int> list)
        {
            Console.WriteLine(string.Join(' ', list.Where(n => n % 2 != 0)));
        }

        public static void GetSum(List<int> list)
        {
            Console.WriteLine(list.Sum());
        }

        public static void Filter(List<int> list, string condition, int number)
        {
            switch (condition)
            {
                case ">":
                    Console.WriteLine(string.Join(' ', list.Where(n => n > number)));
                    break;

                case ">=":
                    Console.WriteLine(string.Join(' ', list.Where(n => n >= number)));
                    break;

                case "<":
                    Console.WriteLine(string.Join(' ', list.Where(n => n < number)));
                    break;

                case "<=":
                    Console.WriteLine(string.Join(' ', list.Where(n => n <= number)));
                    break;
            }
        }
    }
}
