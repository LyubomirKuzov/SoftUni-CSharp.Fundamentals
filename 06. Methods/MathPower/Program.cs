using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateNumber(number, power));
        }

        public static double CalculateNumber(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
