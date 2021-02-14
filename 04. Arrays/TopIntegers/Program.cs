using System;
using System.Linq;
using System.Text;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] >= currNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (!isTopInteger)
                {
                    continue;
                }

                sb.Append($"{currNum} ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
