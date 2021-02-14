using System;
using System.Linq;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] numbers = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            numbers = numbers
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
