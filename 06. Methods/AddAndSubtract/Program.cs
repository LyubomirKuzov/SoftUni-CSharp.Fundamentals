using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateResult(firstNum, secondNum, thirdNum));
        }

        public static int CalculateResult(int firstNum, int secondNum, int thirdNum)
        {
            return Subtract(FindSum(firstNum, secondNum), thirdNum);
        }

        public static int FindSum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public static int Subtract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
    }
}
