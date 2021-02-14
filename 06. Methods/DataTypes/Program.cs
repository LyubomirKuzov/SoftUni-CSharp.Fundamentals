using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string value = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    Print(int.Parse(value));
                    break;

                case "real":
                    Print(double.Parse(value));
                    break;

                case "string":
                    Print(value);
                    break;
            }
        }

        public static void Print(int value)
        {
            Console.WriteLine(value * 2);
        }

        public static void Print(double value)
        {
            Console.WriteLine((value * 1.5).ToString("f2"));
        }

        public static void Print(string value)
        {
            Console.WriteLine($"${value}$");
        }
    }
}
