using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            string winnerPattern = @"(?<separator>[@]{6,9}|[#]{6,9}|[$]{6,9}|[\^]{6,9})";
            string jackpotPattern = @"(?<separator>[@]{10}|[#]{10}|[$]{10}|[\^]{10})";

            for (int i = 0; i < tickets.Length; i++)
            {
                string currentTicket = tickets[i];

                if (currentTicket.Length == 20)
                {
                    string leftHalf = currentTicket.Substring(0, 10);
                    string rightHalf = currentTicket.Substring(10, 10);

                    if (Regex.IsMatch(leftHalf, jackpotPattern) && Regex.IsMatch(rightHalf, jackpotPattern))
                    {
                        Match leftHalfMatch = Regex.Match(leftHalf, jackpotPattern);
                        Match rightHalfMatch = Regex.Match(rightHalf, jackpotPattern);

                        string leftSeparator = leftHalfMatch.Groups["separator"].Value;
                        string rightSeparator = rightHalfMatch.Groups["separator"].Value;

                        if (leftSeparator == rightSeparator && leftSeparator.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - 10{leftSeparator[0]} Jackpot!");
                        }
                    }

                    else if (Regex.IsMatch(leftHalf, winnerPattern) && Regex.IsMatch(rightHalf, winnerPattern))
                    {
                        Match leftHalfMatch = Regex.Match(leftHalf, winnerPattern);
                        Match rightHalfMatch = Regex.Match(rightHalf, winnerPattern);

                        string leftSeparator = leftHalfMatch.Groups["separator"].Value;
                        string rightSeparator = rightHalfMatch.Groups["separator"].Value;

                        if (leftSeparator == rightSeparator && leftSeparator.Length >= 6 && leftSeparator.Length <= 9)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - {leftSeparator.Length}{leftSeparator[0]}");
                        }

                        else if (leftSeparator.Length >= 6 && rightSeparator.Length >= 6)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(leftSeparator.Length, rightSeparator.Length)}{leftSeparator[0]}");
                        }
                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }
                }

                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
