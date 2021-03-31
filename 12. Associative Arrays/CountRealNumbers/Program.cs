using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> numbersDictionary = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (numbersDictionary.ContainsKey(number))
                {
                    numbersDictionary[number]++;
                }

                else
                {
                    numbersDictionary.Add(number, 1);
                }
            }

            foreach (var number in numbersDictionary)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
