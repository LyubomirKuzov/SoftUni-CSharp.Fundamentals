using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int wagonMaxCapacity = int.Parse(Console.ReadLine());

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
                    case "end":
                        Console.WriteLine(string.Join(' ', wagons));
                        return;

                    case "Add":
                        Add(wagons, int.Parse(commandArgs[0]));
                        break;

                    default:
                        FitPassengers(wagons, int.Parse(command), wagonMaxCapacity);
                        break;
                }
            }
        }

        public static void Add(List<int> list, int number)
        {
            list.Add(number);
        }

        public static void FitPassengers(List<int> list, int number, int wagonMaxCapacity)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] + number <= wagonMaxCapacity)
                {
                    list[i] += number;
                    break;
                }
            }
        }
    }
}
