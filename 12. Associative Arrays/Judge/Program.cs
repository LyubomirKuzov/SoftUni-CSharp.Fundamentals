using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> users = new Dictionary<string, int>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" -> ")
                    .ToArray();

                if (command[0] == "no more time")
                {
                    break;
                }

                string username = command[0];
                string contest = command[1];
                int points = int.Parse(command[2]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest].ContainsKey(username))
                    {
                        if (points > contests[contest][username])
                        {
                            int difference = points - contests[contest][username];
                            contests[contest][username] = points;
                            users[username] += difference;
                        }
                    }

                    else
                    {
                        contests[contest].Add(username, points);

                        if (users.ContainsKey(username))
                        {
                            users[username] += points;
                        }

                        else
                        {
                            users.Add(username, points);
                        }
                    }
                }

                else
                {
                    contests.Add(contest, new Dictionary<string, int>()
                    {
                        {username, points }
                    });

                    if (users.ContainsKey(username))
                    {
                        users[username] += points;
                    }

                    else
                    {
                        users.Add(username, points);
                    }
                }
            }

            Print(contests, users);
        }

        private static void Print(Dictionary<string, Dictionary<string, int>> contests,
            Dictionary<string, int> users)
        {
            int position;

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                position = 1;

                foreach (var participant in contest.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{position}. {participant.Key} <::> {participant.Value}");

                    position++;
                }
            }

            Console.WriteLine("Individual standings:");

            position = 1;

            foreach (var user in users
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{position}. {user.Key} -> {user.Value}");

                position++;
            }
        }
    }
}
