using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            text = EncryptText(text);

            Console.WriteLine(text);
        }

        public static string EncryptText(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                sb.Append((char)(text[i] + 3));
            }

            return sb.ToString().Trim();
        }
    }
}
