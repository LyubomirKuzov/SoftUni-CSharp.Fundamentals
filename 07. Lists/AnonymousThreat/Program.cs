using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commandArgs[0];

                commandArgs = commandArgs
                    .Skip(1)
                    .ToArray();

                switch (command)
                {
                    case "merge":
                        Merge(elements, commandArgs);
                        break;

                    case "divide":
                        Divide(elements, commandArgs);
                        break;

                    case "3:1":
                        Console.WriteLine(string.Join(' ', elements));
                        return;
                }
            }
        }

        public static void Merge(List<string> elements, string[] commandArgs)
        {
            int startIndex = int.Parse(commandArgs[0]);
            int endIndex = int.Parse(commandArgs[1]);

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex >= elements.Count)
            {
                endIndex = elements.Count - 1;
            }

            if (startIndex >= 0 && endIndex < elements.Count && startIndex < endIndex)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = startIndex; i <= endIndex; i++)
                {
                    sb.Append(elements[i]);
                }

                elements.RemoveRange(startIndex, endIndex - startIndex + 1);

                if (startIndex <= elements.Count - 1)
                {
                    elements.Insert(startIndex, sb.ToString());
                }

                else
                {
                    elements.Add(sb.ToString());
                }
            }
        }

        public static void Divide(List<string> elements, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[0]);
            int partsCount = int.Parse(commandArgs[1]);

            if (index >= 0 && index < elements.Count)
            {
                string elementToDivide = elements[index];
                elements.RemoveAt(index);
                List<string> newElements = new List<string>();

                if (elementToDivide.Length % partsCount == 0)
                {
                    int symbolsPerPart = elementToDivide.Length / partsCount;

                    while (elementToDivide.Length > 0)
                    {
                        newElements.Add(elementToDivide.Substring(0, symbolsPerPart));
                        elementToDivide = elementToDivide.Remove(0, symbolsPerPart);
                    }

                    if (index <= elements.Count - 1)
                    {
                        elements.InsertRange(index, newElements);
                    }

                    else
                    {
                        elements.AddRange(newElements);
                    }
                }

                else
                {
                    int symbolsPerPart = elementToDivide.Length / (partsCount - 1);
                    int remainingElements = elementToDivide.Length % (partsCount - 1);

                    if (symbolsPerPart >= remainingElements)
                    {
                        remainingElements += (partsCount - 1);
                        symbolsPerPart--;
                    }

                    while (elementToDivide.Length > remainingElements)
                    {
                        newElements.Add(elementToDivide.Substring(0, symbolsPerPart));
                        elementToDivide = elementToDivide.Remove(0, symbolsPerPart);
                    }

                    newElements.Add(elementToDivide);

                    if (index <= elements.Count - 1)
                    {
                        elements.InsertRange(index, newElements);
                    }

                    else
                    {
                        elements.AddRange(newElements);
                    }
                }
            }
        }
    }
}
