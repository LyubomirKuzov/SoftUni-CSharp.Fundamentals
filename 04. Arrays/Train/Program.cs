using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());

            int[] train = new int[wagonsCount];

            for (int i = 0; i < wagonsCount; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(' ', train));
            Console.WriteLine(train.Sum());
        }
    }
}
