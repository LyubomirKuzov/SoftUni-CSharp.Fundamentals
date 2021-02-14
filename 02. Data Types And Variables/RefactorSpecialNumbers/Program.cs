using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbersCount; i++)
            {
                int currentNumber = i;
                int numberSum = 0;

                while (currentNumber != 0)
                {
                    numberSum += currentNumber % 10;
                    currentNumber /= 10;
                }

                bool isStrongNumber = (numberSum == 5) || (numberSum == 7) || (numberSum == 11);

                Console.WriteLine("{0} -> {1}", i, isStrongNumber ? "True" : "False");
            }
        }
    }
}
