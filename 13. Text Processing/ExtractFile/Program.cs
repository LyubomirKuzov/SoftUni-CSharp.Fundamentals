using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine()
                .Split(@"\")
                .ToArray();

            string[] lastPath = path[path.Length - 1]
                .Split('.')
                .ToArray();

            string fileName = lastPath[0];
            string extension = lastPath[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
