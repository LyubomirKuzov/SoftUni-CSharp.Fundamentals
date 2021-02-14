﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers = numbers
                .Where(n => n >= 0)
                .ToList();

            if (numbers.Count > 0)
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(' ', numbers));
            }

            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
