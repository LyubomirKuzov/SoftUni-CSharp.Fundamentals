using System;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            int[] values = new int[linesCount];

            for (int i = 0; i < linesCount; i++)
            {
                string text = Console.ReadLine();

                int sum = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    switch (char.Parse(text[j].ToString().ToLower()))
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            sum += text[j] * text.Length;
                            break;

                        default:
                            sum += text[j] / text.Length;
                            break;
                    }

                    values[i] = sum;
                }
            }

            values = values.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, values));
        }
    }
}
