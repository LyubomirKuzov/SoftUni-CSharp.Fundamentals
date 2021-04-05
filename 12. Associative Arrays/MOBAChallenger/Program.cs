using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new string[] { " -> ", " vs " }, StringSplitOptions.None)
                    .ToArray();

                if (command[0] == "Season end")
                {
                    break;
                }

                if (command.Length == 3)
                {
                    string player = command[0];
                    string position = command[1];
                    int skill = int.Parse(command[2]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>()
                        {
                            {position, skill }
                        });
                    }

                    else
                    {
                        if (players[player].ContainsKey(position))
                        {
                            if (skill > players[player][position])
                            {
                                players[player][position] = skill;
                            }
                        }

                        else
                        {
                            players[player].Add(position, skill);
                        }
                    }
                }

                else if (command.Length == 2)
                {
                    string firstPlayer = command[0];
                    string secondPlayer = command[1];

                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        if (CheckIfPlayersHaveMutualPositions(players[firstPlayer], players[secondPlayer]))
                        {
                            int firstPlayerTotalSkill = CalculateTotalSkill(players[firstPlayer]);
                            int secondPlayerTotalSkill = CalculateTotalSkill(players[secondPlayer]);

                            if (firstPlayerTotalSkill > secondPlayerTotalSkill)
                            {
                                players.Remove(secondPlayer);
                            }

                            else if (secondPlayerTotalSkill > firstPlayerTotalSkill)
                            {
                                players.Remove(firstPlayer);
                            }
                        }
                    }
                }
            }

            Print(players);
        }

        private static int CalculateTotalSkill(Dictionary<string, int> positions)
        {
            int totalSkill = 0;

            foreach (var position in positions)
            {
                totalSkill += position.Value;
            }

            return totalSkill;
        }

        private static void Print(Dictionary<string, Dictionary<string, int>> players)
        {
            players = players
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Sum(x => x.Value)} skill");

                foreach (var position in player.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }

        private static bool CheckIfPlayersHaveMutualPositions(Dictionary<string, int> firstPlayerPositions, 
            Dictionary<string, int> secondPlayerPositions)
        {
            foreach (var position in firstPlayerPositions)
            {
                if (secondPlayerPositions.ContainsKey(position.Key))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
