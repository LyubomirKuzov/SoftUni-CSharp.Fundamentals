using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = commandArgs[0];
                string username = commandArgs[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = commandArgs[2];

                        Register(users, username, licensePlateNumber);
                        break;

                    case "unregister":
                        Unregister(users, username);
                        break;
                }
            }

            Print(users);
        }

        public static void Register(Dictionary<string, string> users, string username, string licensePlateNumber)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            }

            else
            {
                users.Add(username, licensePlateNumber);
                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            }
        }

        public static void Unregister(Dictionary<string, string> users, string username)
        {
            if (users.ContainsKey(username))
            {
                users.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
            }

            else
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
        }

        public static void Print(Dictionary<string, string> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
