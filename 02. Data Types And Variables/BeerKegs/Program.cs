using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());

            string biggestModel = string.Empty;
            float biggestVolume = 0.0f;

            for (int i = 0; i < kegsCount; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float currentKegVolume = (float)Math.PI * radius * radius * height;

                if (currentKegVolume > biggestVolume)
                {
                    biggestModel = model;
                    biggestVolume = currentKegVolume;
                }
            }

            Console.WriteLine(biggestModel);
        }
    }
}
