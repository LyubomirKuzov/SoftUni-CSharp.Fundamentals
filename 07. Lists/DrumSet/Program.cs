using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drumsQuality = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> copyOfQuality = new List<int>(drumsQuality);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Hit it again, Gabsy!")
                {
                    Console.WriteLine(string.Join(' ', drumsQuality));
                    Console.WriteLine($"Gabsy has {savings:f2}lv.");
                    break;
                }

                int hitPower = int.Parse(command);

                for (int i = 0; i < drumsQuality.Count; i++)
                {
                    drumsQuality[i] -= hitPower;

                    if (drumsQuality[i] <= 0)
                    {
                        double priceForNewDrum = copyOfQuality[i] * 3;

                        if (savings - priceForNewDrum >= 0)
                        {
                            savings -= priceForNewDrum;
                            drumsQuality[i] = copyOfQuality[i];
                        }

                        else
                        {
                            drumsQuality.RemoveAt(i);
                            copyOfQuality.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }
    }
}
