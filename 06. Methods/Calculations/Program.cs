using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Console.WriteLine(Add(firstNum, secondNum));
                    break;

                case "multiply":
                    Console.WriteLine(Multiply(firstNum, secondNum));
                    break;

                case "subtract":
                    Console.WriteLine(Subtract(firstNum, secondNum));
                    break;

                case "divide":
                    Console.WriteLine(Divide(firstNum, secondNum));
                    break;
            }
        }

        public static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public static int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        public static int Subtract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        public static int Divide(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }
    }
}
