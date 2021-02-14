using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOperations
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

                string command = commandArgs[0];

                commandArgs = commandArgs
                    .Skip(1)
                    .ToArray();

                switch (command)
                {
                    case "End":
                        Console.WriteLine(string.Join(' ', numbers));
                        return;

                    case "Add":
                        Add(numbers, commandArgs);
                        break;

                    case "Insert":
                        Insert(numbers, commandArgs);
                        break;

                    case "Remove":
                        Remove(numbers, commandArgs);
                        break;

                    case "Shift":
                        switch (commandArgs[0])
                        {
                            case "left":
                                ShiftLeft(numbers, commandArgs.Skip(1).ToArray());
                                break;

                            case "right":
                                ShiftRight(numbers, commandArgs.Skip(1).ToArray());
                                break;
                        }
                        break;
                }
            }
        }

        public static void Add(List<int> list, string[] commandArgs)
        {
            int number = int.Parse(commandArgs[0]);

            list.Add(number);
        }

        public static void Insert(List<int> list, string[] commandArgs)
        {
            int number = int.Parse(commandArgs[0]);
            int index = int.Parse(commandArgs[1]);

            if (index >= 0 && index < list.Count)
            {
                list.Insert(index, number);
            }

            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        public static void Remove(List<int> list, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[0]);

            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }

            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        public static void ShiftLeft(List<int> list, string[] commandArgs)
        {
            int count = int.Parse(commandArgs[0]);

            for (int i = 0; i < count; i++)
            {
                int firstNumber = list[0];

                for (int j = 0; j < list.Count - 1; j++)
                {
                    list[j] = list[j + 1];
                }

                list[list.Count - 1] = firstNumber;
            }
        }

        public static void ShiftRight(List<int> list, string[] commandArgs)
        {
            int count = int.Parse(commandArgs[0]);

            for (int i = 0; i < count; i++)
            {
                int lastNumber = list[list.Count - 1];

                for (int j = list.Count - 1; j > 0 ; j--)
                {
                    list[j] = list[j - 1];
                }

                list[0] = lastNumber;
            }
        }
    }
}
