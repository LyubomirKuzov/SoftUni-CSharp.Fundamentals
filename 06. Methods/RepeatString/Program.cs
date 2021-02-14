using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            Console.WriteLine(ConcatenateString(text, repeatCount));
        }

        public static string ConcatenateString(string text, int repeatCount)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < repeatCount; i++)
            {
                sb.Append(text);
            }

            return sb.ToString();
        }
    }
}
