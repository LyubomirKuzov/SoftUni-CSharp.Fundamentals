using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            Console.WriteLine(string.Concat(message.Reverse()));
        }
    }
}
