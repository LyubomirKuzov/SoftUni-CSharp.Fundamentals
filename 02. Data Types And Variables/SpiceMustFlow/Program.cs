using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int spiceIncome = int.Parse(Console.ReadLine());

            int extractedSpice = 0;
            int daysCount = 0;

            while (true)
            {
                if (spiceIncome < 100)
                {
                    break;
                }

                daysCount++;
                extractedSpice += spiceIncome;
                spiceIncome -= 10;

                if (extractedSpice >= 26)
                {
                    extractedSpice -= 26;
                }
            }

            if (extractedSpice >= 26)
            {
                extractedSpice -= 26;
            }

            Console.WriteLine(daysCount);
            Console.WriteLine(extractedSpice);
        }
    }
}
