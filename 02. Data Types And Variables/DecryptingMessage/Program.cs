using System;
using System.Text;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int charsCount = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < charsCount; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sb.Append((char)(symbol + key));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
