using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*[<](?<product>\w+)[>][^|$%.]*[\|](?<count>\d+)[\|][^|$%.]*?(?<price>[0-9]+[\.]?[0-9]+?)?[$]$";

            double moneyEarned = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }

                if (Regex.IsMatch(input, pattern))
                {
                    Match newMatch = Regex.Match(input, pattern);

                    string customer = newMatch.Groups["customer"].Value;
                    string product = newMatch.Groups["product"].Value;
                    int count = int.Parse(newMatch.Groups["count"].Value);
                    double price = double.Parse(newMatch.Groups["price"].Value);

                    Console.WriteLine($"{customer}: {product} - {count * price:f2}");
                    moneyEarned += count * price;
                }
            }

            Console.WriteLine($"Total income: {moneyEarned:f2}");
        }
    }
}
