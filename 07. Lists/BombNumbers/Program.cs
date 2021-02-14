using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] specialNumberArgs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int specialNumber = specialNumberArgs[0];
            int specialNumberPower = specialNumberArgs[1];

            while (numbers.Contains(specialNumber))
            {
                numbers = Detonate(numbers, specialNumber, specialNumberPower);
            }

            Console.WriteLine(numbers.Sum());
        }

        public static List<int> Detonate(List<int> numbers, int specialNumber, int specialNumberPower)
        {
            int specialNumberIndex = numbers.IndexOf(specialNumber);
            int leftStartingIndex = specialNumberIndex - specialNumberPower;
            int rightEndIndex = specialNumberIndex + specialNumberPower;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i >= leftStartingIndex && i <= rightEndIndex)
                {
                    numbers[i] = int.MinValue;
                }
            }

            numbers = numbers
                .Where(n => n != int.MinValue)
                .ToList();

            return numbers;
        }
    }
}
