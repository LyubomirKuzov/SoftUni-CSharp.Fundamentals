using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            StringBuilder message = new StringBuilder();

            for (int i = 0; i < numbers.Count; i++)
            {
                int sumOfDigits = CalculateNumberDigitsSum(numbers[i]);

                int textIndex = -1;

                if (sumOfDigits < text.Length)
                {
                    textIndex = sumOfDigits;
                }

                else
                {
                    while (sumOfDigits >= text.Length)
                    {
                        sumOfDigits--;
                        textIndex++;

                        if (textIndex == text.Length)
                        {
                            textIndex = 0;
                        }
                    }
                }

                message.Append(text[textIndex]);
                text = text.Remove(textIndex, 1);
            }

            Console.WriteLine(message.ToString());
        }

        public static int CalculateNumberDigitsSum(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
