using System;
using System.Text;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int lettersCount = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int l = 0; l < lettersCount; l++)
            {
                string combination = Console.ReadLine();

                int digit = int.Parse(combination[0].ToString());
                string possibleLetters = string.Empty;
                int clicksCount = combination.Length;

                switch (digit)
                {
                    case 2:
                        possibleLetters = "abc";
                        break;

                    case 3:
                        possibleLetters = "def";
                        break;

                    case 4:
                        possibleLetters = "ghi";
                        break;

                    case 5:
                        possibleLetters = "jkl";
                        break;

                    case 6:
                        possibleLetters = "mno";
                        break;

                    case 7:
                        possibleLetters = "pqrs";
                        break;

                    case 8:
                        possibleLetters = "tuv";
                        break;

                    case 9:
                        possibleLetters = "wxyz";
                        break;

                    case 0:
                        possibleLetters = " ";
                        break;
                }

                char symbol = possibleLetters[clicksCount - 1];
                sb.Append(symbol);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
