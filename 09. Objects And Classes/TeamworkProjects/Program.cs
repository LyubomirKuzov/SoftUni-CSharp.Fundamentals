using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] teamArgs = Console.ReadLine()
                    .Split(new char[] { '-' })
                    .ToArray();

                string creator = teamArgs[0];
                string teamName = teamArgs[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }

                else
                {
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                }
            }

            while (true)
            {
                string[] userArgs = Console.ReadLine()
                    .Split("->")
                    .ToArray();

                if (userArgs[0] == "end of assignment")
                {
                    break;
                }

                string user = userArgs[0];
                string teamName = userArgs[1];

                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                else if (teams.Any(t => t.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }

                else
                {
                    Team team = teams.First(t => t.Name == teamName);
                    team.Members.Add(user);
                }
            }

            var teamsToDisband = teams
                .Where(t => t.Members.Count() == 0)
                .OrderBy(t => t.Name)
                .ToList();

            teams = teams
                .Where(t => t.Members.Count() > 0)
                .OrderByDescending(t => t.Members.Count())
                .ThenBy(t => t.Name)
                .ToList();

            foreach (var t in teams)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine("- " + t.Creator);

                foreach (var m in t.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {m}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var t in teamsToDisband)
            {
                Console.WriteLine(t.Name);
            }
        }
    }

    public class Team
    {
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = new List<string>();
        }



        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}
