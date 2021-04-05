using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { '-' })
                    .ToArray();

                if (command[0] == "exam finished")
                {
                    break;
                }

                if (command[command.Length - 1] == "banned")
                {
                    string username = command[0];

                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                }

                else
                {
                    string username = command[0];
                    string language = command[1];
                    int points = int.Parse(command[2]);

                    if (users.ContainsKey(username) && points > users[username])
                    {
                        users[username] = points;
                    }

                    else if(!users.ContainsKey(username))
                    {
                        users.Add(username, points);
                    }

                    if (!languages.ContainsKey(language))
                    {
                        languages.Add(language, 0);
                    }

                    languages[language]++;
                }
            }

            Print(users, languages);
        }

        private static void Print(Dictionary<string, int> users, Dictionary<string, int> languages)
        {
            Console.WriteLine("Results:");

            users = users
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            languages = languages
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Submissions:");

            foreach (var language in languages)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
