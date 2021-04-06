using System;
using System.Linq;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word);
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
