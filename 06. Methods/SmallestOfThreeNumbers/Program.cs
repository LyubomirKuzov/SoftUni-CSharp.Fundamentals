using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(FindSmallestNumber(firstNum, secondNum, thirdNum));
        }

        public static int FindSmallestNumber(int firstNum, int secondNum, int thirdNum)
        {
            return Math.Min(firstNum, Math.Min(secondNum, thirdNum));
        }
    }
}
