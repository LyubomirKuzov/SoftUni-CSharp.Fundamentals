using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<int> resultList = new List<int>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                Append(resultList, arrays[i]);
            }

            Console.WriteLine(string.Join(' ', resultList));
        }

        public static void Append(List<int> list, string input)
        {
            int[] numbers = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            list.AddRange(numbers);
        }
    }
}
