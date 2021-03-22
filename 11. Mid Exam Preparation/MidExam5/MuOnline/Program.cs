using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            var rooms = Console.ReadLine()
                .Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int roomCount = 1;

            for (int i = 0; i < rooms.Length; i+=2)
            {
                var roomType = rooms[i];
                int value = int.Parse(rooms[i + 1]);

                switch (roomType)
                {
                    case "potion":
                        int initialHealth = health;
                        health += value;

                        if (health > 100)
                        {
                            health = 100;
                        }

                        Console.WriteLine($"You healed for {health - initialHealth} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;

                    case "chest":
                        bitcoins += value;

                        Console.WriteLine($"You found {value} bitcoins.");
                        break;

                    default:
                        health -= value;

                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {roomType}.");
                        }

                        else
                        {
                            Console.WriteLine($"You died! Killed by {roomType}.");
                            Console.WriteLine($"Best room: {roomCount}");
                            return;
                        }
                        break;
                }

                roomCount++;
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
