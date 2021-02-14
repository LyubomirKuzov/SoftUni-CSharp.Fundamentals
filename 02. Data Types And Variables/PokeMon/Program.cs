using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokedTargetsCount = 0;
            int originalValue = pokePower;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokedTargetsCount++;

                if (pokePower == (decimal)originalValue / 2 && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargetsCount);
        }
    }
}
