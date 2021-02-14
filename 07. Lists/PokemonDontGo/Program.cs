using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonDistances = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> removedElements = new List<int>();

            while (true)
            {
                int index = int.Parse(Console.ReadLine());

                int currElement = 0;

                if (index < 0)
                {
                    currElement = pokemonDistances[0];
                    pokemonDistances.RemoveAt(0);
                    pokemonDistances.Insert(0, pokemonDistances[pokemonDistances.Count - 1]);
                }

                else if (index >= 0 && index < pokemonDistances.Count)
                {
                    currElement = pokemonDistances[index];
                    pokemonDistances.RemoveAt(index);
                }

                else if (index >= pokemonDistances.Count)
                {
                    currElement = pokemonDistances[pokemonDistances.Count - 1];
                    pokemonDistances.RemoveAt(pokemonDistances.Count - 1);
                    pokemonDistances.Add(pokemonDistances[0]);
                }

                removedElements.Add(currElement);

                for (int i = 0; i < pokemonDistances.Count; i++)
                {
                    if (pokemonDistances[i] <= currElement)
                    {
                        pokemonDistances[i] += currElement;
                    }

                    else
                    {
                        pokemonDistances[i] -= currElement;
                    }
                }

                if (pokemonDistances.Count == 0)
                {
                    break;
                }
            }

            Console.WriteLine(removedElements.Sum());
        }
    }
}
