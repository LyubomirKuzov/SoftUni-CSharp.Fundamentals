using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculatePrice(product, quantity).ToString("f2"));
        }

        public static double CalculatePrice(string product, int quantity)
        {
            switch (product)
            {
                case "coffee":
                    return quantity * 1.50;

                case "water":
                    return quantity * 1;

                case "coke":
                    return quantity * 1.40;

                case "snacks":
                    return quantity * 2;

                default:
                    return 0;
            }
        }
    }
}
