using System;
using System.Linq;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                long[] numbers = Console.ReadLine()
                    .Split(new char[] { ' ' })
                    .Select(long.Parse)
                    .ToArray();

                long firstNumber = numbers[0];
                long secondNumber = numbers[1];

                long biggerNumber = Math.Max(firstNumber, secondNumber);

                Console.WriteLine(FindSum(Math.Abs(biggerNumber)));
            }
        }

        private static int FindSum(long number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum = sum + (int)(number % 10);
                number /= 10;
            }

            return sum;
        }
    }
}
