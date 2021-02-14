using System;
using System.Text;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = start; i <= end; i++)
            {
                sb.Append((char)i + " ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
