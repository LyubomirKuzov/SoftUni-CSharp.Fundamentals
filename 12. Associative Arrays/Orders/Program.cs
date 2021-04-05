using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            while (true)
            {
                string[] productArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (productArgs[0] == "buy")
                {
                    break;
                }

                string productName = productArgs[0];
                double productPrice = double.Parse(productArgs[1]);
                double productQuantity = double.Parse(productArgs[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new double[2]);

                }

                products[productName][0] = productPrice;
                products[productName][1] += productQuantity;
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
            }
        }
    }
}
