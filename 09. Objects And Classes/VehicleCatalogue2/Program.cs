using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue2
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            while (true)
            {
                string[] vehicleArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (vehicleArgs[0] == "End")
                {
                    break;
                }

                string type = vehicleArgs[0];
                string model = vehicleArgs[1];
                string color = vehicleArgs[2];
                double horsePower = double.Parse(vehicleArgs[3]);

                switch (type)
                {
                    case "car":
                        Car car = new Car(model, color, horsePower);
                        catalogue.Cars.Add(car);
                        break;

                    case "truck":
                        Truck truck = new Truck(model, color, horsePower);
                        catalogue.Trucks.Add(truck);
                        break;
                }
            }

            while (true)
            {
                string model = Console.ReadLine();

                if (model == "Close the Catalogue")
                {
                    if (catalogue.Cars.Count() == 0)
                    {
                        Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                        Console.WriteLine($"Trucks have average horsepower of: {(double)catalogue.Trucks.Sum(t => t.HorsePower) / catalogue.Trucks.Count():f2}.");
                    }

                    else if (catalogue.Trucks.Count() == 0)
                    {
                        Console.WriteLine($"Cars have average horsepower of: {(double)catalogue.Cars.Sum(c => c.HorsePower) / catalogue.Cars.Count():f2}.");
                        Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
                    }

                    else
                    {
                        Console.WriteLine($"Cars have average horsepower of: {(double)catalogue.Cars.Sum(c => c.HorsePower) / catalogue.Cars.Count():f2}.");
                        Console.WriteLine($"Trucks have average horsepower of: {(double)catalogue.Trucks.Sum(t => t.HorsePower) / catalogue.Trucks.Count():f2}.");
                    }

                    break;
                }

                if (catalogue.Cars.Any(c => c.Model == model))
                {
                    Car car = catalogue.Cars.First(c => c.Model == model);
                    Console.WriteLine(car.ToString());
                }

                else if (catalogue.Trucks.Any(t => t.Model == model))
                {
                    Truck truck = catalogue.Trucks.First(t => t.Model == model);
                    Console.WriteLine(truck.ToString());
                }
            }
        }
    }

    public class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }



        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

    public class Car
    {
        public Car(string model, string color, double horsePower)
        {
            this.Type = nameof(Car);
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }



        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }



        public override string ToString()
        {
            return $"Type: {this.Type}\nModel: {this.Model}\nColor: {this.Color}\nHorsepower: {this.HorsePower}";
        }
    }

    public class Truck
    {
        public Truck(string model, string color, double horsePower)
        {
            this.Type = nameof(Truck);
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }



        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }



        public override string ToString()
        {
            return $"Type: {this.Type}\nModel: {this.Model}\nColor: {this.Color}\nHorsepower: {this.HorsePower}";
        }
    }
}
