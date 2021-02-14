using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{number} X {i + 1} = {number * (i + 1)}");
            }
        }
    }
}
