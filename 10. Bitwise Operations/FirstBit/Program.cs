using System;

namespace FirstBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = number >> 1;

            Console.WriteLine(number & 1);
        }
    }
}
