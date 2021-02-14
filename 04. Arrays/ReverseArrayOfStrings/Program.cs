using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            elements = elements
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join(' ', elements));
        }
    }
}
