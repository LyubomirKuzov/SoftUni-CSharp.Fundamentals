using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorial(N));
        }

        private static BigInteger CalculateFactorial(int N)
        {
            BigInteger result = 1;

            for (int i = 1; i <= N; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
