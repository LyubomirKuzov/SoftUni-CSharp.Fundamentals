using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int bestStudentAttendancesCount = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int attendancesCount = int.Parse(Console.ReadLine());

                double totalBonus = 1.0 * attendancesCount / lecturesCount * (5 + initialBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    bestStudentAttendancesCount = attendancesCount;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {bestStudentAttendancesCount} lectures.");
        }
    }
}
