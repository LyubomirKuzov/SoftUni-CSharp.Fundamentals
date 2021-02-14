using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLength = CalculateLineLength(x1, y1, x2, y2);
            double secondLineLength = CalculateLineLength(x3, y3, x4, y4);

            if (firstLineLength > secondLineLength)
            {
                Print(x1, y1, x2, y2);
            }

            else
            {
                Print(x3, y3, x4, y4);
            }
        }

        public static double CalculatePointResult(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public static double CalculateLineLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((Math.Abs(x1 - x2)), 2) + Math.Pow((Math.Abs(y1 - y2)), 2));
        }

        public static void Print(double x1, double y1, double x2, double y2)
        {
            double firstPointValue = CalculatePointResult(x1, y1);
            double secondPointValue = CalculatePointResult(x2, y2);

            int comparisonResult = firstPointValue.CompareTo(secondPointValue);

            switch (comparisonResult)
            {
                case -1:
                case 0:
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                    break;

                case 1:
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                    break;
            }
        }
    }
}
