using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine().ToLower();
            string secondString = Console.ReadLine().ToLower();

            while (secondString.Contains(firstString))
            {
                int startIndex = secondString.IndexOf(firstString);
                secondString = secondString.Remove(startIndex, firstString.Length);
            }

            Console.WriteLine(secondString);
        }
    }
}
