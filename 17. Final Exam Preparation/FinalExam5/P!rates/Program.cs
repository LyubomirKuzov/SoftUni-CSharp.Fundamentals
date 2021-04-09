using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = AddCities();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split("=>")
                    .ToArray();

                if (command[0] == "End")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Plunder":
                        Plunder(command, cities);
                        break;

                    case "Prosper":
                        Prosper(command, cities);
                        break;
                }
            }

            cities = cities
                .OrderByDescending(x => x.Gold)
                .ThenBy(x => x.Name)
                .ToList();

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }

            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        private static List<City> AddCities()
        {
            List<City> cities = new List<City>();

            while (true)
            {
                string[] cityArgs = Console.ReadLine()
                    .Split("||")
                    .ToArray();

                if (cityArgs[0] == "Sail")
                {
                    break;
                }

                string cityName = cityArgs[0];
                int population = int.Parse(cityArgs[1]);
                int gold = int.Parse(cityArgs[2]);

                if (cities.Any(x => x.Name == cityName))
                {
                    var city = cities.First(x => x.Name == cityName);

                    city.Population += population;
                    city.Gold += gold;
                }

                else
                {
                    var city = new City()
                    {
                        Name = cityName,
                        Population = population,
                        Gold = gold
                    };

                    cities.Add(city);
                }
            }

            return cities;
        }

        private static void Plunder(string[] command, List<City> cities)
        {
            string cityName = command[1];
            int people = int.Parse(command[2]);
            int gold = int.Parse(command[3]);

            var city = cities.First(x => x.Name == cityName);
            city.Population -= people;
            city.Gold -= gold;

            Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

            if (city.Population <= 0 || city.Gold <= 0)
            {
                cities.Remove(city);
                Console.WriteLine($"{cityName} has been wiped off the map!");
            }
        }

        private static void Prosper(string[] command, List<City> cities)
        {
            string cityName = command[1];
            int gold = int.Parse(command[2]);

            if (gold >= 0)
            {
                var city = cities.First(x => x.Name == cityName);
                city.Gold += gold;

                Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {city.Gold} gold.");
            }

            else
            {
                Console.WriteLine("Gold added cannot be a negative number!");
            }
        }
    }

    class City
    {
        public string Name { get; set; }

        public int Population { get; set; }

        public int Gold { get; set; }
    }
}
