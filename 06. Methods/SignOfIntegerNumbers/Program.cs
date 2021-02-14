using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(DetermineOutput(number));
        }

        private static string DetermineOutput(int number)
        {
            if (number > 0)
            {
                return $"The number {number} is positive.";
            }

            else if (number < 0)
            {
                return $"The number {number} is negative.";
            }

            else
            {
                return $"The number {number} is zero.";
            }
        }
    }
}
