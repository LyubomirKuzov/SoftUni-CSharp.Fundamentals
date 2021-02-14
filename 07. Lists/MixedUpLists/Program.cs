using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> mixedList = new List<int>();

            int smallerListLength = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < smallerListLength; i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[secondList.Count - 1 - i]);
            }

            firstList.RemoveRange(0, smallerListLength);
            secondList.RemoveRange(secondList.Count - smallerListLength, smallerListLength);

            int start = -1;
            int end = -1;

            FindRangeToPrint(firstList, secondList, ref start, ref end);

            FindAndPrintElementsInRange(start, end, mixedList);
        }

        public static void FindRangeToPrint(List<int> firstList, List<int> secondList, ref int start, ref int end)
        {
            if (firstList.Count == 0)
            {
                start = secondList[0];
                end = secondList[1];
            }

            else if (secondList.Count == 0)
            {
                start = firstList[0];
                end = firstList[1];
            }
        }

        public static void FindAndPrintElementsInRange(int start, int end, List<int> mixedList)
        {
            List<int> elementsInRange = new List<int>();

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > Math.Min(start, end) && mixedList[i] < Math.Max(start, end))
                {
                    elementsInRange.Add(mixedList[i]);
                }
            }

            elementsInRange.Sort();

            Console.WriteLine(string.Join(' ', elementsInRange));
        }
    }
}
