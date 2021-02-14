using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
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
                    case "end":
                        Console.WriteLine(string.Join(' ', list));
                        return;

                    case "Delete":
                        Delete(list, int.Parse(commandArgs[0]));
                        break;

                    case "Insert":
                        Insert(list, int.Parse(commandArgs[0]), int.Parse(commandArgs[1]));
                        break;
                }
            }
        }

        public static void Delete(List<int> list, int element)
        {
            list.RemoveAll(e => e == element);
        }

        public static void Insert(List<int> list, int element, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.Insert(index, element);
            }

            else if (index > list.Count - 1)
            {
                list.Add(element);
            }
        }
    }
}
