using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ', '-', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Craft!")
                {
                    Console.WriteLine(string.Join(", ", items));
                    break;
                }

                switch (command[0])
                {
                    case "Collect":
                        if (!items.Contains(command[1]))
                        {
                            items.Add(command[1]);
                        }
                        break;

                    case "Drop":
                        if (items.Contains(command[1]))
                        {
                            items.Remove(command[1]);
                        }
                        break;

                    case "Combine":
                        if (items.Contains(command[2]))
                        {
                            int index = items.IndexOf(command[2]);
                            items.Insert(index + 1, command[3]);
                        }
                        break;

                    case "Renew":
                        if (items.Contains(command[1]))
                        {
                            items.Remove(command[1]);
                            items.Add(command[1]);
                        }
                        break;
                }
            }
        }
    }
}
