using System;
using System.Text;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            long[] sequence = new long[numbersCount];

            if (numbersCount == 1)
            {
                Console.WriteLine("1");
            }

            else if (numbersCount == 2)
            {
                Console.WriteLine("1 1");
            }

            else
            {
                sequence[0] = 1;
                sequence[1] = 1;
                sequence[2] = 2;
                int counter = 3;

                while (counter < numbersCount)
                {
                    long nextNumber = CalculateNextNumber(sequence, counter);
                    sequence[counter] = nextNumber;
                    counter++;
                }

                Console.WriteLine(string.Join(' ', sequence));
            }
        }

        static long CalculateNextNumber(long[] sequence, int counter)
        {
            long nextNumber = 0;

            for (int i = counter - 1; i >= counter - 3; i--)
            {
                nextNumber += sequence[i];
            }

            return nextNumber;
        }
    }
}
