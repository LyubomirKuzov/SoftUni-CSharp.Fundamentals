using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int oddSum = 0;
            int evenSum = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }

                else
                {
                    oddSum += number;
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
