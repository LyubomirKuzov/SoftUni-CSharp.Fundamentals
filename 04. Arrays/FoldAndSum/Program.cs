using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int quarterCount = numbers.Length / 4;
            int counter = quarterCount - 1;

            for (int i = quarterCount; i < numbers.Length - quarterCount; i++)
            {
                if (i < numbers.Length / 2)
                {
                    numbers[i] += numbers[counter];
                    counter--;
                }
                
                else
                {
                    numbers[i] += numbers[numbers.Length - 1 - counter];
                    counter++;
                }

                if (i == numbers.Length / 2 - 1)
                {
                    counter = 0;
                }
            }

            numbers = numbers
                .Skip(quarterCount)
                .Take(numbers.Length - 2 * quarterCount)
                .ToArray();

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
