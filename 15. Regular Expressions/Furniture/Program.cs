using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">{2}(?<name>[A-z]+)<{2}(?<price>\d+\.?\d+)!(?<quantity>\d+)";
            List<string> products = new List<string>();
            double moneySpend = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                if (Regex.IsMatch(input, pattern))
                {
                    Match newProduct = Regex.Match(input, pattern);

                    products.Add(newProduct.Groups["name"].Value);
                    moneySpend += double.Parse(newProduct.Groups["price"].Value) * double.Parse(newProduct.Groups["quantity"].Value);
                }
            }

            Print(products, moneySpend);
        }

        static void Print(List<string> products, double moneySpend)
        {
            Console.WriteLine("Bought furniture:");

            foreach (string product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine($"Total money spend: {moneySpend:f2}");
        }
    }
}
