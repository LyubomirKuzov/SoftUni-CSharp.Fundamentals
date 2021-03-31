using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToArray();

            if (numbers.Length > 3)
            {
                numbers = numbers
                    .Take(3)
                    .ToArray();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
