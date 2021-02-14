using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());

            List<string> productsList = new List<string>();

            for (int i = 0; i < productsCount; i++)
            {
                productsList.Add(Console.ReadLine());
            }

            productsList.Sort();

            for (int i = 0; i < productsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{productsList[i]}");
            }
        }
    }
}
