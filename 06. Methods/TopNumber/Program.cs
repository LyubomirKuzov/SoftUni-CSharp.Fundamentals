using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (CalculateNumberSum(i) % 8 == 0 && ContainsOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static int CalculateNumberSum(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        public static bool ContainsOddDigit(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}
