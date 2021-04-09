using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int messagesCount = int.Parse(Console.ReadLine());

            string lettersCountPattern = @"[STARstar]";
            string decryptedPattern = @"@(?<name>[A-z]+)[^@\-!:>]*?:[^@\-!:>]*?(?<population>\d+)[^@\-!:>]*?![^@\-!:>]*?(?<attack>[AD])[^@\-!:>]*?![^@\-!:>]*?->[^@\-!:>]*?(?<soldiers>\d+)";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < messagesCount; i++)
            {
                string message = Console.ReadLine();

                MatchCollection lettersCollection = Regex.Matches(message, lettersCountPattern);

                int lettersCount = lettersCollection.Count;
                string decryptedMessage = DecryptMessage(message, lettersCount);

                if (Regex.IsMatch(decryptedMessage, decryptedPattern))
                {
                    Match newMatch = Regex.Match(decryptedMessage, decryptedPattern);

                    string attackType = newMatch.Groups["attack"].Value;
                    string planetName = newMatch.Groups["name"].Value;

                    switch (attackType)
                    {
                        case "A":
                            attackedPlanets.Add(planetName);
                            break;

                        case "D":
                            destroyedPlanets.Add(planetName);
                            break;
                    }
                }
            }

            attackedPlanets.Sort();
            destroyedPlanets.Sort();
            Print(attackedPlanets, destroyedPlanets);
        }

        static string DecryptMessage(string message, int lettersCount)
        {
            StringBuilder decryptedMessage = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                decryptedMessage.Append((char)(message[i] - lettersCount));
            }

            return decryptedMessage.ToString().Trim();
        }

        static void Print(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (string planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (string planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
