using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DragonType> dragons = AddDragons();

            Print(dragons);
        }

        static Dictionary<string, DragonType> AddDragons()
        {
            int inputCount = int.Parse(Console.ReadLine());

            Dictionary<string, DragonType> dragons = new Dictionary<string, DragonType>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = input[0];
                string name = input[1];

                int damage;
                int health;
                int armor;

                if (input[2] == "null")
                {
                    damage = 45;
                }

                else
                {
                    damage = int.Parse(input[2]);
                }

                if (input[3] == "null")
                {
                    health = 250;
                }

                else
                {
                    health = int.Parse(input[3]);
                }

                if (input[4] == "null")
                {
                    armor = 10;
                }

                else
                {
                    armor = int.Parse(input[4]);
                }

                if (dragons.ContainsKey(type))
                {
                    if (dragons[type].DragonsData.ContainsKey(name))
                    {
                        dragons[type].AverageDamage -= dragons[type].DragonsData[name].Damage;
                        dragons[type].AverageHealth -= dragons[type].DragonsData[name].Health;
                        dragons[type].AverageArmor -= dragons[type].DragonsData[name].Armor;
                        dragons[type].AverageDamage += damage;
                        dragons[type].AverageHealth += health;
                        dragons[type].AverageArmor += armor;
                        dragons[type].DragonsData[name].Damage = damage;
                        dragons[type].DragonsData[name].Health = health;
                        dragons[type].DragonsData[name].Armor = armor;
                    }

                    else
                    {
                        dragons[type].DragonsData.Add(name, new Dragon()
                        {
                            Damage = damage,
                            Health = health,
                            Armor = armor
                        });

                        dragons[type].AverageDamage += damage;
                        dragons[type].AverageHealth += health;
                        dragons[type].AverageArmor += armor;
                    }
                }

                else
                {
                    dragons.Add(type, new DragonType()
                    {
                        AverageDamage = damage,

                        AverageHealth = health,

                        AverageArmor = armor,

                        DragonsData = new Dictionary<string, Dragon>()
                        {
                            { name, new Dragon()
                                {
                                    Damage = damage,
                                    Health = health,
                                    Armor = armor
                                }
                            }
                        }
                    });
                }
            }

            return dragons;
        }

        static void Print(Dictionary<string, DragonType> dragons)
        {
            foreach (var type in dragons)
            {
                Console.WriteLine($"{type.Key}::({type.Value.AverageDamage / type.Value.DragonsData.Count:f2}/{type.Value.AverageHealth / type.Value.DragonsData.Count:f2}/{type.Value.AverageArmor / type.Value.DragonsData.Count:f2})");

                type.Value.DragonsData = type.Value.DragonsData.OrderBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

                foreach (var dragon in type.Value.DragonsData)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.Damage}, health: {dragon.Value.Health}, armor: {dragon.Value.Armor}");
                }
            }
        }
    }

    class DragonType
    {
        public Dictionary<string, Dragon> DragonsData { get; set; }

        public decimal AverageHealth { get; set; }

        public decimal AverageDamage { get; set; }

        public decimal AverageArmor { get; set; }
    }

    class Dragon
    {
        public int Health { get; set; }

        public int Damage { get; set; }

        public int Armor { get; set; }
    }
}
