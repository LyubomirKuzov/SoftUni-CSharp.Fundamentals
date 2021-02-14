using System;
using System.Linq;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] oddArr = new int[N];
            int[] evenArr = new int[N];

            for (int i = 0; i < N; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    evenArr[i] = numbers[0];
                    oddArr[i] = numbers[1];
                }

                else
                {
                    oddArr[i] = numbers[0];
                    evenArr[i] = numbers[1];
                }
            }

            Console.WriteLine(string.Join(' ', evenArr));
            Console.WriteLine(string.Join(' ', oddArr));
        }
    }
}
