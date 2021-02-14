using System;

namespace LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (char.IsUpper(symbol))
            {
                Console.WriteLine("upper-case");
            }

            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
