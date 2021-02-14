using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int currentNumber = i;
                int numberSum = 0;

                while (currentNumber != 0)
                {
                    numberSum += currentNumber % 10;
                    currentNumber /= 10;
                }

                Console.WriteLine($"{i} -> {(numberSum == 5 || numberSum == 7 || numberSum == 11 ? "True" : "False")}");
            }
        }
    }
}
