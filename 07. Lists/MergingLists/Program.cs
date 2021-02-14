using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
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

            List<int> mergedList = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                mergedList.Add(firstList[i]);
                mergedList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                firstList.RemoveRange(0, secondList.Count);
                mergedList.AddRange(firstList);
            }

            else if (secondList.Count > firstList.Count)
            {
                secondList.RemoveRange(0, firstList.Count);
                mergedList.AddRange(secondList);
            }

            Console.WriteLine(string.Join(' ', mergedList));
        }
    }
}
