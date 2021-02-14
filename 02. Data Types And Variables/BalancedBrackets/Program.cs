using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            int leftBrackets = 0;
            int rightBrackets = 0;
            int leftBracketsInRow = 0;
            int rightBracketsInRow = 0;
            bool notBalaced = false;

            for (int i = 0; i < linesCount; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    leftBrackets++;
                    leftBracketsInRow++;
                    rightBracketsInRow = 0;

                    if (leftBracketsInRow > 1)
                    {
                        notBalaced = true;
                    }
                }

                else if (input == ")")
                {
                    rightBrackets++;
                    rightBracketsInRow++;
                    leftBracketsInRow = 0;

                    if (rightBracketsInRow > 1 || rightBrackets > leftBrackets)
                    {
                        notBalaced = true;
                    }
                }

                if (i == linesCount - 1 && leftBrackets != rightBrackets)
                {
                    notBalaced = true;
                }
            }

            if (notBalaced == true)
            {
                Console.WriteLine("UNBALANCED");
            }

            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
