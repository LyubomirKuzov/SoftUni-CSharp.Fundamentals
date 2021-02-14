using System;
using System.Text;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            int[] firstArr = new int[0];
            StringBuilder sb = new StringBuilder();

            for (int r = 0; r < rowsCount; r++)
            {
                int[] secondArr = new int[firstArr.Length + 1];

                for (int c = 0; c <= r; c++)
                {
                    if (c == 0 || c == r)
                    {
                        secondArr[c] = 1;
                    }

                    else
                    {
                        secondArr[c] = firstArr[c - 1] + firstArr[c];
                    }
                }

                firstArr = secondArr;
                sb.AppendLine(string.Join(' ', firstArr));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
