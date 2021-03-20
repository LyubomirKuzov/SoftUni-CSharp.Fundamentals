using System;

namespace Tri_bitSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 7 << position;

            Console.WriteLine(number ^ mask);
        }
    }
}
