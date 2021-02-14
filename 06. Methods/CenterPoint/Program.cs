using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPointResult = CalculatePointResult(x1, y1);
            double secondPointResult = CalculatePointResult(x2, y2);

            int comparisonResult = firstPointResult.CompareTo(secondPointResult);

            switch (comparisonResult)
            {
                case -1:
                case 0:
                    PrintResult(x1, y1);
                    break;

                case 1:
                    PrintResult(x2, y2);
                    break;
            }
        }

        public static double CalculatePointResult(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public static void PrintResult(double x, double y)
        {
            Console.WriteLine($"({x}, {y})");
        }
    }
}
