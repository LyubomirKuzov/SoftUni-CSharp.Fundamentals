using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int originalLength = numbers.Count / 2;

            for (int i = 0; i < originalLength; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
