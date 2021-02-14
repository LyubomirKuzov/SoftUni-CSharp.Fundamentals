using System;
using System.Text;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    sb.Append($"{r + 1} ");
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
