using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string names = Console.ReadLine();

            var matches = Regex.Matches(names, pattern);

            foreach (Match name in matches)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
