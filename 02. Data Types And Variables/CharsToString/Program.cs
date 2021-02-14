using System;
using System.Text;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                sb.Append(Console.ReadLine());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
