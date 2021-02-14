using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int minNumber = Math.Min(firstNum, Math.Min(secondNum, thirdNum));
            int maxNumber = Math.Max(firstNum, Math.Max(secondNum, thirdNum));
            int middleNumber = (firstNum + secondNum + thirdNum) - (maxNumber + minNumber);

            Console.WriteLine(maxNumber);
            Console.WriteLine(middleNumber);
            Console.WriteLine(minNumber);
        }
    }
}
