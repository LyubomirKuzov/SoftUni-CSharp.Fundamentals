using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = 0;
            int trashedKeyboardCount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 6 == 0)
                {
                    expenses += (mousePrice + headsetPrice + keyboardPrice);
                    trashedKeyboardCount++;

                    if (trashedKeyboardCount % 2 == 0)
                    {
                        expenses += displayPrice;
                    }
                }

                else if (i % 3 == 0)
                {
                    expenses += mousePrice;
                }

                else if (i % 2 == 0)
                {
                    expenses += headsetPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
