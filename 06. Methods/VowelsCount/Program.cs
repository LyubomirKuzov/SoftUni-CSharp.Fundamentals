using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(FindVowelsCount(text));
        }

        public static int FindVowelsCount(string text)
        {
            int vowelsCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (char.ToLower(text[i]))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                        vowelsCount++;
                        break;
                }
            }

            return vowelsCount;
        }
    }
}
