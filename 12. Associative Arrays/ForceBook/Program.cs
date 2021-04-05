using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Lumpawaroo")
                {
                    break;
                }

                string delimeter = string.Empty;
                string forceSide = string.Empty;
                string forceUser = string.Empty;

                if (command.Contains("|"))
                {
                    delimeter = " | ";
                }

                else if (command.Contains(" -> "))
                {
                    delimeter = " -> ";
                }

                string[] commandArgs = command
                    .Split(delimeter)
                    .ToArray();

                switch (delimeter)
                {
                    case " | ":
                        forceSide = commandArgs[0];
                        forceUser = commandArgs[1];

                        if (!sides.Values.Any(x => x.Any(y => y == forceUser)))
                        {
                            if (!sides.ContainsKey(forceSide))
                            {
                                sides.Add(forceSide, new List<string>());
                            }

                            sides[forceSide].Add(forceUser);
                        }
                        break;

                    case " -> ":
                        forceUser = commandArgs[0];
                        forceSide = commandArgs[1];

                        if (sides.Values.Any(x => x.Any(y => y == forceUser)))
                        {
                            string side = FindForceSide(sides, forceUser);

                            sides[side].Remove(forceUser);

                            if (!sides.ContainsKey(forceSide))
                            {
                                sides.Add(forceSide, new List<string>());
                            }

                            sides[forceSide].Add(forceUser);
                        }

                        else
                        {
                            if (!sides.ContainsKey(forceSide))
                            {
                                sides.Add(forceSide, new List<string>());
                            }

                            sides[forceSide].Add(forceUser);
                        }
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        break;
                }
            }

            Print(sides);
        }

        private static string FindForceSide(Dictionary<string, List<string>> sides, string forceUser)
        {
            string forceSide = string.Empty;

            foreach (var side in sides)
            {
                if (side.Value.Contains(forceUser))
                {
                    return side.Key;
                }
            }

            return null;
        }

        private static void Print(Dictionary<string, List<string>> sides)
        {
            sides = sides
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var side in sides)
            {
                if (side.Value.Count > 0)
                {
                    List<string> forceUsers = side.Value
                        .OrderBy(x => x)
                        .ToList();

                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                    foreach (var user in forceUsers)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
