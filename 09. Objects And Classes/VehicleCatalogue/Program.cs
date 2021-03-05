using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            while (true)
            {
                string[] vehicleArgs = Console.ReadLine()
                    .Split(new char[] { '/' })
                    .ToArray();

                if (vehicleArgs[0] == "end")
                {
                    break;
                }

                string type = vehicleArgs[0];
                string brand = vehicleArgs[1];
                string model = vehicleArgs[2];

                switch (type)
                {
                    case "Car":
                        double horsePower = double.Parse(vehicleArgs[3]);

                        Car car = new Car()
                        {
                            Brand = brand,
                            Model = model,
                            HorsePower = horsePower
                        };

                        catalog.Cars.Add(car);
                        break;

                    case "Truck":
                        double weight = double.Parse(vehicleArgs[3]);

                        Truck truck = new Truck()
                        {
                            Brand = brand,
                            Model = model,
                            Weight = weight
                        };

                        catalog.Trucks.Add(truck);
                        break;
                }
            }

            Print(catalog);
        }

        private static void Print(Catalog catalog)
        {
            Console.WriteLine("Cars:");
            foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (var truck in catalog.Trucks.OrderBy(t => t.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    public class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }



        public ICollection<Truck> Trucks { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
