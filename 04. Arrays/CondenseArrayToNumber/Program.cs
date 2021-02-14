using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (numbers.Length > 1)
            {
                int[] tempNumbers = new int[numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    tempNumbers[i] = numbers[i] + numbers[i + 1];
                }

                numbers = tempNumbers;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
