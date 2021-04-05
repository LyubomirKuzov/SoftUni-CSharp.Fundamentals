using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            AddContests(contests);

            Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();
            AddSubmissions(submissions, contests);

            Print(submissions, contests);
        }

        private static void AddContests(Dictionary<string, string> contests)
        {
            while (true)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(new char[] { ':', '=', '>' })
                    .ToArray();

                if (inputArgs[0] == "end of contests")
                {
                    break;
                }

                string contestName = inputArgs[0];
                string contestPassword = inputArgs[1];

                contests.Add(contestName, contestPassword);
            }
        }

        private static void AddSubmissions(Dictionary<string, Dictionary<string, int>> submissions,
            Dictionary<string, string> contests)
        {
            while (true)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(new char[] { ':', '=', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (inputArgs[0] == "end of submissions")
                {
                    break;
                }

                string contest = inputArgs[0];
                string password = inputArgs[1];
                string username = inputArgs[2];
                int points = int.Parse(inputArgs[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!submissions.ContainsKey(username))
                    {
                        submissions.Add(username, new Dictionary<string, int>()
                        {
                            {contest, points }
                        });
                    }

                    else
                    {
                        if (!submissions[username].ContainsKey(contest))
                        {
                            submissions[username].Add(contest, points);
                        }

                        else
                        {
                            if (points > submissions[username][contest])
                            {
                                submissions[username][contest] = points;
                            }
                        }
                    }
                }
            }
        }

        private static void Print(Dictionary<string, Dictionary<string, int>> submissions,
            Dictionary<string, string> contests)
        {
            int maxPoints = submissions.Max(x => x.Value.Sum(y => y.Value));
            string bestCandidate = submissions.First(x => x.Value.Sum(y => y.Value) == maxPoints).Key;

            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");

            submissions = submissions
                .OrderBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var submission in submissions)
            {
                Console.WriteLine(submission.Key);

                foreach (var contest in submission.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
