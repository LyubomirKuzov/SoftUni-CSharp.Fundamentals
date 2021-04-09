using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Demon> demonsCollection = new SortedDictionary<string, Demon>();

            string healthPattern = @"[^0-9+\-*\/\.]";
            string damagePattern = @"[+-]?[0-9]+\.?[0-9]*";

            List<string> input = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                input[i] = input[i].Trim();
            }

            for (int i = 0; i < input.Count; i++)
            {
                string name = input[i];

                MatchCollection healthCollection = Regex.Matches(input[i], healthPattern);

                int health = 0;

                for (int j = 0; j < healthCollection.Count; j++)
                {
                    health += char.Parse(healthCollection[j].Value);
                }

                MatchCollection damageCollection = Regex.Matches(input[i], damagePattern);

                double damage = 0;

                for (int j = 0; j < damageCollection.Count; j++)
                {
                    damage += double.Parse(damageCollection[j].Value);
                }

                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == '*')
                    {
                        damage *= 2;
                    }

                    else if (name[j] == '/')
                    {
                        damage /= 2;
                    }
                }

                Demon newDemon = new Demon()
                {
                    Health = health,
                    Damage = damage
                };

                demonsCollection.Add(name, newDemon);
            }

            foreach (var item in demonsCollection)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Health} health, {item.Value.Damage:f2} damage");
            }
        }
    }

    public class Demon
    {
        public int Health { get; set; }
        public double Damage { get; set; }
    }
}
