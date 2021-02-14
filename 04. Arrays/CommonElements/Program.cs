using System;
using System.Linq;
using System.Text;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < secondArr.Length; i++)
            {
                if (firstArr.Any(e => e == secondArr[i]))
                {
                    sb.Append($"{secondArr[i]} ");
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
