using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (command.Length)
                {
                    case 3:
                        AddGuest(guests, command[0]);
                        break;

                    case 4:
                        RemoveGuest(guests, command[0]);
                        break;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }

        public static void AddGuest(List<string> list, string guestName)
        {
            if (list.Contains(guestName))
            {
                Console.WriteLine($"{guestName} is already in the list!");
            }

            else
            {
                list.Add(guestName);
            }
        }

        public static void RemoveGuest(List<string> list, string guestName)
        {
            if (list.Contains(guestName))
            {
                list.Remove(guestName);
            }

            else
            {
                Console.WriteLine($"{guestName} is not in the list!");
            }
        }
    }
}
