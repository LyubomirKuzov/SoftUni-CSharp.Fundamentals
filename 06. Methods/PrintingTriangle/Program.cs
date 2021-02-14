using System;
using System.Text;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                AppendRow(i, sb);
            }

            for (int i = N - 2; i >= 0; i--)
            {
                AppendRow(i, sb);
            }

            Console.WriteLine(sb.ToString());
        }

        public static void AppendRow(int number, StringBuilder sb)
        {
            for (int i = 0; i <= number; i++)
            {
                sb.Append((i + 1) + " ");
            }

            sb.AppendLine().ToString().Trim();
        }
    }
}
