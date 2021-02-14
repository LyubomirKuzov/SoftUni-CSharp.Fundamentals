using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());

            for (int r = 0; r < rotationsCount; r++)
            {
                int firstElement = numbers[0];

                for (int e = 1; e < numbers.Length; e++)
                {
                    numbers[e - 1] = numbers[e];
                }

                numbers[numbers.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
