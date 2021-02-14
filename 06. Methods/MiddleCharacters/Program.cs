using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(GetMiddleCharacters(text));
        }

        public static string GetMiddleCharacters(string text)
        {
            if (text.Length % 2 == 0)
            {
                return text.Substring(text.Length / 2 - 1, 2);
            }

            else
            {
                return text[text.Length / 2].ToString();
            }
        }
    }
}
