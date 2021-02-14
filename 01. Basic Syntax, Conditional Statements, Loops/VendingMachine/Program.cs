using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Start")
                {
                    break;
                }

                double coins = double.Parse(input);

                switch (coins)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        totalMoney += coins;
                        break;

                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
            }

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "End")
                {
                    break;
                }

                double productPrice = 0;

                switch (product)
                {
                    case "Nuts":
                        productPrice = 2;
                        break;

                    case "Water":
                        productPrice = 0.7;
                        break;

                    case "Crisps":
                        productPrice = 1.5;
                        break;

                    case "Soda":
                        productPrice = 0.8;
                        break;

                    case "Coke":
                        productPrice = 1;
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                }

                if (totalMoney - productPrice < 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                else
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    totalMoney -= productPrice;
                }
            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
