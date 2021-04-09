using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> participantsData = new Dictionary<string, int>();

            List<string> winnerNames = new List<string>();

            string namePattern = @"[A-Z]|[a-z]";
            string distancePattern = @"\d";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of race")
                {
                    break;
                }

                MatchCollection nameCollection = Regex.Matches(input, namePattern);

                MatchCollection distanceCollection = Regex.Matches(input, distancePattern);

                string participantName = string.Join("", nameCollection);

                int distance = Distance(distanceCollection);

                if (participants.Contains(participantName))
                {
                    if (participantsData.ContainsKey(participantName))
                    {
                        participantsData[participantName] += distance;
                    }

                    else
                    {
                        participantsData.Add(participantName, distance);
                    }
                }
            }

            participantsData = participantsData
                .OrderByDescending(x => x.Value)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in participantsData)
            {
                winnerNames.Add(item.Key.ToString());
            }

            Console.WriteLine($"1st place: {winnerNames[0]}");
            Console.WriteLine($"2nd place: {winnerNames[1]}");
            Console.WriteLine($"3rd place: {winnerNames[2]}");
        }

        static int Distance(MatchCollection distanceCollection)
        {
            int totalDistance = 0;

            foreach (var item in distanceCollection)
            {
                totalDistance += int.Parse(item.ToString());
            }

            return totalDistance;
        }
    }
}
