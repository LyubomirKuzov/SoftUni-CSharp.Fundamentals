using System;
using System.Numerics;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            byte secondNumber = byte.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber * secondNumber);
        }
    }
}
