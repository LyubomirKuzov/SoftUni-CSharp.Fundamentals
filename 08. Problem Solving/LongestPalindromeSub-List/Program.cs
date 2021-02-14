using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestPalindromeSub_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int longestPalindromeCount = 1;

            for (int i = 0; i < text.Length; i++)
            {
                int currPalindromeCount = 1;
                int centralIndex = i;
                int leftElementIndex = -1;
                int rightElementIndex = -1;

                if (i > 0 && i < text.Length - 1)
                {
                    leftElementIndex = i - 1;
                    rightElementIndex = i + 1;

                    while (leftElementIndex >= 0 && rightElementIndex < text.Length && text[leftElementIndex] == text[rightElementIndex])
                    {
                        leftElementIndex--;
                        rightElementIndex++;
                        currPalindromeCount += 2;
                    }

                    if (currPalindromeCount > longestPalindromeCount)
                    {
                        longestPalindromeCount = currPalindromeCount;
                    }
                }

                int leftCentralIndex = i;
                int rightCentralIndex = i + 1;

                if (rightCentralIndex < text.Length && text[leftCentralIndex] == text[rightCentralIndex])
                {
                    currPalindromeCount = 2;
                    leftElementIndex = leftCentralIndex - 1;
                    rightElementIndex = rightCentralIndex + 1;

                    while (leftElementIndex >= 0 && rightElementIndex < text.Length && text[leftElementIndex] == text[rightElementIndex])
                    {
                        leftElementIndex--;
                        rightElementIndex++;
                        currPalindromeCount += 2;
                    }

                    if (currPalindromeCount > longestPalindromeCount)
                    {
                        longestPalindromeCount = currPalindromeCount;
                    }
                }
            }

            Console.WriteLine(longestPalindromeCount);
        }
    }
}
