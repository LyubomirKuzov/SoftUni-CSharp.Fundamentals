using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int firstNum = 0;
            int secondNum = 1;

            for (int i = 0; i < N - 1; i++)
            {
                int temp = secondNum;
                secondNum = firstNum + secondNum;
                firstNum = temp;
            }

            Console.WriteLine(secondNum);
        }
    }
}
