﻿using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                sum += letter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
