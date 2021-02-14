using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateResult(firstNum, operation, secondNum));
        }

        public static double CalculateResult(int firstNum, char operation, int secondNum)
        {
            switch (operation)
            {
                case '+':
                    return firstNum + secondNum;

                case '-':
                    return firstNum - secondNum;

                case '*':
                    return firstNum * secondNum;

                case '/':
                    return firstNum / secondNum;

                default:
                    return 0;
            }
        }
    }
}
