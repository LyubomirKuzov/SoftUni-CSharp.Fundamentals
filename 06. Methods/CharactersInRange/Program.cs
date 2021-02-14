using System;
using System.Text;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            Console.WriteLine(GenerateSequence(firstChar, secondChar));
        }

        public static string GenerateSequence(char firstChar, char secondChar)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = Math.Min(firstChar, secondChar) + 1; i < Math.Max(firstChar, secondChar); i++)
            {
                sb.Append($"{(char)i} ");
            }

            return sb.ToString().Trim();
        }
    }
}
