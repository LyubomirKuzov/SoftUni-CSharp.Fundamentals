using System;
using System.Text;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int sum = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = start; i <= end; i++)
            {
                sum += i;
                sb.Append(i + " ");
            }

            Console.WriteLine(sb.ToString().Trim());
            Console.WriteLine("Sum: " + sum);
        }
    }
}
