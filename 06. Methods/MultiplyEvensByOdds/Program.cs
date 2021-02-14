using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int oddSum = FindOddAndEvenSum(number).Item1;
            int evenSum = FindOddAndEvenSum(number).Item2;

            Console.WriteLine(oddSum * evenSum);
        }

        public static (int, int) FindOddAndEvenSum(int number)
        {
            int oddSum = 0;
            int evenSum = 0;

            while (number != 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }

                else
                {
                    oddSum += digit;
                }

                number /= 10;
            }

            return (oddSum, evenSum);
        }
    }
}
