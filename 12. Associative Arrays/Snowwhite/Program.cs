using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> sortedDwarfs = new List<Dwarf>();

            Dictionary<string, List<Dwarf>> dwarfs = AddDwarfs(sortedDwarfs);

            sortedDwarfs = sortedDwarfs
                .OrderByDescending(x => x.Physics)
                .ThenByDescending(x => dwarfs[x.Color].Count)
                .ToList();

            foreach (var dwarf in sortedDwarfs)
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }

        private static Dictionary<string, List<Dwarf>> AddDwarfs(List<Dwarf> sortedDwarfs)
        {
            Dictionary<string, List<Dwarf>> dwarfs = new Dictionary<string, List<Dwarf>>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" <:> ")
                    .ToArray();

                if (command[0] == "Once upon a time")
                {
                    break;
                }

                string name = command[0];
                string color = command[1];
                int physics = int.Parse(command[2]);

                if (!dwarfs.ContainsKey(color))
                {
                    dwarfs.Add(color, new List<Dwarf>());
                }

                if (!dwarfs[color].Any(x => x.Name == name))
                {
                    Dwarf dwarf = new Dwarf()
                    {
                        Name = name,
                        Color = color,
                        Physics = physics
                    };

                    dwarfs[color].Add(dwarf);
                    sortedDwarfs.Add(dwarf);
                }

                else
                {
                    Dwarf existingDwarf = dwarfs[color].FirstOrDefault(x => x.Name == name);
                    existingDwarf.Physics = Math.Max(existingDwarf.Physics, physics);
                }
            }

            return dwarfs;
        }
    }

    public class Dwarf
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Physics { get; set; }
    }
}
