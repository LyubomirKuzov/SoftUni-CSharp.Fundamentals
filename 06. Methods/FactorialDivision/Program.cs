using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            long firstNumFactorial = CalculateFactorial(Math.Abs(firstNum));
            long secondNumFactorial = CalculateFactorial(Math.Abs(secondNum));
            double result = (double)firstNumFactorial / secondNumFactorial;

            Console.WriteLine(result.ToString("f2"));
        }

        public static long CalculateFactorial(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            long factorial = 1;

            for (long i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
