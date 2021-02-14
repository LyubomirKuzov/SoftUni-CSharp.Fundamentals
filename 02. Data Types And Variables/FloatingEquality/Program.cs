using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());

            decimal difference = Math.Abs(firstNum - secondNum);

            if (difference.ToString().Length > 8)
            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
