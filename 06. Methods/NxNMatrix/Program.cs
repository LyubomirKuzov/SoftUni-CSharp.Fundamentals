using System;
using System.Text;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < number; i++)
            {
                AddLine(number, sb);
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        public static void AddLine(int number, StringBuilder sb)
        {
            for (int i = 0; i < number; i++)
            {
                sb.Append(number + " ");
            }

            sb.AppendLine();
        }
    }
}
