using System;
using System.Linq;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int binaryDigit = int.Parse(Console.ReadLine());

            string numberAsBinary = Convert.ToString(number, 2);

            int count = numberAsBinary
                .ToCharArray()
                .Where(x => x.ToString() == binaryDigit.ToString())
                .Count();

            Console.WriteLine(count);
        }
    }
}
