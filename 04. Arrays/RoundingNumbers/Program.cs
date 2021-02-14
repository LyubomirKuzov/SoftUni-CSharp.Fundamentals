using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{(decimal)number} => {(decimal)Math.Round(number, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
