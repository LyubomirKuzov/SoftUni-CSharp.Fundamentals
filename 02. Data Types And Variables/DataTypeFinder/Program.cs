using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                bool isInteger = int.TryParse(input, out int integerNum);
                if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                    continue;
                }

                bool isFloatNumber = float.TryParse(input, out float floatNum);
                if (isFloatNumber)
                {
                    Console.WriteLine($"{input} is floating point type");
                    continue;
                }

                bool isChar = char.TryParse(input, out char charNum);
                if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                    continue;
                }

                if (input.ToLower() == "true" || input.ToLower() == "false")
                {
                    Console.WriteLine($"{input} is boolean type");
                    continue;
                }

                Console.WriteLine($"{input} is string type");
            }
        }
    }
}
