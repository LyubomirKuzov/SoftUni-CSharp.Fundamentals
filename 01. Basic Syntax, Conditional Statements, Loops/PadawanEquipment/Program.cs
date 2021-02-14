using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsabersCount = Math.Ceiling(studentsCount * 1.1);
            int beltsCount = studentsCount - (studentsCount / 6);

            double totalPrice = lightsaberPrice * lightsabersCount + robePrice * studentsCount + beltPrice * beltsCount;

            if (moneyAvailable >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }

            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - moneyAvailable:f2}lv more.");
            }
        }
    }
}
