using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string number = Console.ReadLine();

                if (number == "END")
                {
                    break;
                }

                string reversedNumber = string.Concat(number.Reverse());

                Console.WriteLine(number == reversedNumber ? "true" : "false");
            }
        }
    }
}
