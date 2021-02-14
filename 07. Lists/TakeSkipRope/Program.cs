using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<int> digitsList = new List<int>();
            List<char> nonDigitsList = new List<char>();

            ExtractDigitsFromText(text, digitsList, nonDigitsList);

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            SplitDigitsInTwoLists(digitsList, takeList, skipList);

            StringBuilder hiddenMessage = new StringBuilder();
            text = string.Join("", nonDigitsList);

            int toSkipCount = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<char> tempNonDigitsList = new List<char>(nonDigitsList);

                tempNonDigitsList = tempNonDigitsList
                    .Skip(toSkipCount)
                    .Take(takeList[i])
                    .ToList();

                hiddenMessage.Append(string.Join("", tempNonDigitsList));

                toSkipCount += (takeList[i] + skipList[i]);
            }

            Console.WriteLine(hiddenMessage.ToString());
        }

        public static void ExtractDigitsFromText(string text, List<int> digitsList, List<char> nonDigitsList)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digitsList.Add(int.Parse(text[i].ToString()));
                }

                else
                {
                    nonDigitsList.Add(text[i]);
                }
            }
        }

        public static void SplitDigitsInTwoLists(List<int> digitsList, List<int> takeList, List<int> skipList)
        {
            for (int i = 0; i < digitsList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digitsList[i]);
                }

                else
                {
                    skipList.Add(digitsList[i]);
                }
            }
        }
    }
}
