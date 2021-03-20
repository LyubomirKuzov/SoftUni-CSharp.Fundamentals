using System;

namespace N_thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            number = number >> position;

            Console.WriteLine(number & 1);
        }
    }
}
