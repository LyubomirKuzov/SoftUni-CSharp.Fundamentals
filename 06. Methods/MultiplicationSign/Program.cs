using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            int result = DetermineOutput(firstNum, secondNum, thirdNum);

            PrintOutput(result);
        }

        public static int DetermineOutput(double firstNum, double secondNum, double thirdNum)
        {
            double result = firstNum * secondNum * thirdNum;

            if (result < 0)
            {
                return -1;
            }

            else if (result == 0)
            {
                return 0;
            }

            else
            {
                return 1;
            }
        }

        public static void PrintOutput(int result)
        {
            switch (result)
            {
                case -1:
                    Console.WriteLine("negative");
                    break;

                case 0:
                    Console.WriteLine("zero");
                    break;

                case 1:
                    Console.WriteLine("positive");
                    break;
            }
        }
    }
}
