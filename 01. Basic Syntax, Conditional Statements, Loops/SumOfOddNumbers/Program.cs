using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumbersCount = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int n = 1; n <= oddNumbersCount * 2; n+=2)
            {
                Console.WriteLine(n);
                sum += n;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
