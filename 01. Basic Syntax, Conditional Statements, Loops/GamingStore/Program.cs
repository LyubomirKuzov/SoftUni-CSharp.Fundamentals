using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyBalance = double.Parse(Console.ReadLine());

            double moneySpentOnGames = 0;

            while (true)
            {
                string gameName = Console.ReadLine();

                if (gameName == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${moneySpentOnGames:f2}. Remaining: ${moneyBalance:f2}");
                    break;
                }

                double gamePrice = 0;

                switch (gameName)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;

                    case "CS: OG":
                        gamePrice = 15.99;
                        break;

                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;

                    case "Honored 2":
                        gamePrice = 59.99;
                        break;

                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;

                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (moneyBalance - gamePrice < 0)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                moneyBalance -= gamePrice;
                moneySpentOnGames += gamePrice;
                Console.WriteLine($"Bought {gameName}");

                if (moneyBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
        }
    }
}
