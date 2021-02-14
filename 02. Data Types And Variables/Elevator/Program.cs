using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int coursesCount = (int)(Math.Ceiling((double)peopleCount / elevatorCapacity));

            Console.WriteLine(coursesCount);
        }
    }
}
