using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> junkResources = new SortedDictionary<string, int>();

            Dictionary<string, int> importantResources = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"fragments", 0 },
                {"motes", 0 }
            };

            bool itemFound = false;

            while (true)
            {
                string[] resourcesInput = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int i = 0; i < resourcesInput.Length; i += 2)
                {
                    int quantity = int.Parse(resourcesInput[i]);
                    string resource = resourcesInput[i + 1].ToLower();

                    if (importantResources.ContainsKey(resource))
                    {
                        importantResources[resource] += quantity;

                        if (importantResources[resource] >= 250)
                        {
                            itemFound = true;
                            break;
                        }
                    }

                    else
                    {
                        if (junkResources.ContainsKey(resource))
                        {
                            junkResources[resource] += quantity;
                        }

                        else
                        {
                            junkResources.Add(resource, quantity);
                        }
                    }
                }

                if (itemFound)
                {
                    break;
                }
            }

            string legendaryItem = FindLegendaryItem(importantResources);

            PrintOutput(legendaryItem,
                importantResources.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value),
                junkResources);
        }

        private static string FindLegendaryItem(Dictionary<string, int> importantResources)
        {
            string legendaryItem = string.Empty;

            string maxResource = importantResources.FirstOrDefault(x => x.Value >= 250).Key;
            importantResources[maxResource] -= 250;

            switch (maxResource)
            {
                case "shards":
                    legendaryItem = "Shadowmourne";
                    break;

                case "fragments":
                    legendaryItem = "Valanyr";
                    break;

                case "motes":
                    legendaryItem = "Dragonwrath";
                    break;
            }

            return legendaryItem;
        }

        private static void PrintOutput(string legendaryItem, Dictionary<string, int> importantResources,
            SortedDictionary<string, int> junkResources)
        {
            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (var item in importantResources)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkResources)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
