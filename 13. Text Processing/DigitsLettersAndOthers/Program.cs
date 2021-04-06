using System;
using System.Text;

namespace DigitsLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            string text = Console.ReadLine();

            foreach (var symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }

                else if (char.IsLetter(symbol))
                {
                    letters.Append(symbol);
                }

                else
                {
                    others.Append(symbol);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
