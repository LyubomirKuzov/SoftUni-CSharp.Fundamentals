using System;
using System.Linq;
using System.Text;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commandArgs[0] == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", array)}]");
                    break;
                }

                string command = commandArgs[0];

                commandArgs = commandArgs
                    .Skip(1)
                    .ToArray();

                switch (command)
                {
                    case "exchange":
                        array = Exchange(array, commandArgs);
                        break;

                    case "max":
                        Max(array, commandArgs);
                        break;

                    case "min":
                        Min(array, commandArgs);
                        break;

                    case "first":
                        First(array, commandArgs);
                        break;

                    case "last":
                        Last(array, commandArgs);
                        break;

                }
            }
        }

        public static int[] Exchange(int[] array, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[0]);

            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            else
            {
                int[] firstPart = array
                    .Take(index + 1)
                    .ToArray();

                int[] secondPart = array
                    .Skip(index + 1)
                    .ToArray();

                for (int i = 0; i < secondPart.Length; i++)
                {
                    array[i] = secondPart[i];
                }

                int counter = 0;

                for (int i = secondPart.Length; i < array.Length; i++)
                {
                    array[i] = firstPart[counter];
                    counter++;
                }

                return array;
            }
        }

        public static void Max(int[] array, string[] commandArgs)
        {
            int index = -1;
            int maxElement = int.MinValue;

            string option = commandArgs[0];

            switch (option)
            {
                case "even":
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0 && array[i] >= maxElement)
                        {
                            maxElement = array[i];
                            index = i;
                        }
                    }
                    break;

                case "odd":
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 != 0 && array[i] >= maxElement)
                        {
                            maxElement = array[i];
                            index = i;
                        }
                    }
                    break;
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }

            else
            {
                Console.WriteLine(index);
            }
        }

        public static void Min(int[] array, string[] commandArgs)
        {
            int index = -1;
            int minElement = int.MaxValue;

            string option = commandArgs[0];

            switch (option)
            {
                case "even":
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0 && array[i] <= minElement)
                        {
                            minElement = array[i];
                            index = i;
                        }
                    }
                    break;

                case "odd":
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 != 0 && array[i] <= minElement)
                        {
                            minElement = array[i];
                            index = i;
                        }
                    }
                    break;
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }

            else
            {
                Console.WriteLine(index);
            }
        }

        public static void First(int[] array, string[] commandArgs)
        {
            int count = int.Parse(commandArgs[0]);
            string option = commandArgs[1];

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }

            else
            {
                int[] tempArr = new int[count];
                int elementsSelected = 0;

                switch (option)
                {
                    case "even":
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                tempArr[elementsSelected] = array[i];
                                elementsSelected++;
                            }

                            if (elementsSelected == count)
                            {
                                break;
                            }
                        }
                        break;

                    case "odd":
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 != 0)
                            {
                                tempArr[elementsSelected] = array[i];
                                elementsSelected++;
                            }

                            if (elementsSelected == count)
                            {
                                break;
                            }
                        }
                        break;
                }

                tempArr = tempArr
                    .Take(elementsSelected)
                    .ToArray();

                Console.WriteLine($"[{string.Join(", ", tempArr)}]");
            }
        }

        public static void Last(int[] array, string[] commandArgs)
        {
            int count = int.Parse(commandArgs[0]);
            string option = commandArgs[1];

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }

            else
            {
                int[] tempArr = new int[count];
                int elementsSelected = 0;

                switch (option)
                {
                    case "even":
                        for (int i = array.Length - 1; i >= 0; i--)
                        {
                            if (array[i] % 2 == 0)
                            {
                                tempArr[elementsSelected] = array[i];
                                elementsSelected++;
                            }

                            if (elementsSelected == count)
                            {
                                break;
                            }
                        }
                        break;

                    case "odd":
                        for (int i = array.Length - 1; i >= 0; i--)
                        {
                            if (array[i] % 2 != 0)
                            {
                                tempArr[elementsSelected] = array[i];
                                elementsSelected++;
                            }

                            if (elementsSelected == count)
                            {
                                break;
                            }
                        }
                        break;
                }

                tempArr = tempArr
                          .Take(elementsSelected)
                          .Reverse()
                          .ToArray();

                Console.WriteLine($"[{string.Join(", ", tempArr)}]");
            }
        }
    }
}
