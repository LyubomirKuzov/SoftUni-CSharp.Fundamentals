using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string numberAsString = number.ToString();
            int factorialSum = 0;

            for (int d = 0; d < numberAsString.Length; d++)
            {
                int currentDigit = int.Parse(numberAsString[d].ToString());
                int currentDigitFactorial = 1;

                for (int f = 1; f <= currentDigit; f++)
                {
                    currentDigitFactorial *= f;
                }

                factorialSum += currentDigitFactorial;
            }

            if (number == factorialSum)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
