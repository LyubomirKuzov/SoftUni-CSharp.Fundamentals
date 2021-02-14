using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            switch (type)
            {
                case "int":
                    GetMax(int.Parse(firstValue), int.Parse(secondValue));
                    break;

                case "char":
                    GetMax(char.Parse(firstValue), char.Parse(secondValue));
                    break;

                case "string":
                    GetMax(firstValue, secondValue);
                    break;
            }
        }

        public static void GetMax(int firstValue, int secondValue)
        {
            Console.WriteLine(firstValue > secondValue ? firstValue : secondValue);
        }

        public static void GetMax(char firstValue, char secondValue)
        {
            Console.WriteLine(firstValue > secondValue ? firstValue : secondValue);
        }

        public static void GetMax(string firstValue, string secondValue)
        {
            int result = string.Compare(firstValue, secondValue);

            switch (result)
            {
                case -1:
                    Console.WriteLine(secondValue);
                    break;

                default:
                    Console.WriteLine(firstValue);
                    break;
            }
        }
    }
}
