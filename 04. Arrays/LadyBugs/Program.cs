using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] ladybugsIndexes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = AddLadyBugsInField(ladybugsIndexes, fieldSize);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    Console.WriteLine(string.Join(' ', field));
                    break;
                }

                string[] command = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int index = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (index >= 0 && index < fieldSize && field[index] == 1)
                {
                    field[index] = 0;

                    int landIndex = 0;

                    switch (direction)
                    {
                        case "left":
                            landIndex = index - flyLength;
                            break;

                        case "right":
                            landIndex = index + flyLength;
                            break;
                    }

                    if (landIndex >= 0 && landIndex < fieldSize)
                    {
                        if (field[landIndex] == 0)
                        {
                            field[landIndex] = 1;
                        }

                        else
                        {
                            while (landIndex >= 0 && landIndex < fieldSize && field[landIndex] == 1)
                            {
                                switch (direction)
                                {
                                    case "left":
                                        landIndex -= flyLength;
                                        break;

                                    case "right":
                                        landIndex += flyLength;
                                        break;
                                }
                            }

                            if (landIndex >= 0 && landIndex < fieldSize)
                            {
                                field[landIndex] = 1;
                            }
                        }
                    }
                }
            }
        }

        private static int[] AddLadyBugsInField(int[] ladybugsIndexes, int fieldSize)
        {
            ladybugsIndexes = ladybugsIndexes
                .Where(x => x >= 0 && x < fieldSize)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < ladybugsIndexes.Length; i++)
            {
                field[ladybugsIndexes[i]] = 1;
            }

            return field;
        }
    }
}
