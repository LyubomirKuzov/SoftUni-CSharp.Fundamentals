using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                string model = carArgs[0];
                int engineSpeed = int.Parse(carArgs[1]);
                int enginePower = int.Parse(carArgs[2]);
                int cargoWeight = int.Parse(carArgs[3]);
                string cargoType = carArgs[4];

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);
                cars.Add(car);
            }

            string desiredCargo = Console.ReadLine();

            switch (desiredCargo)
            {
                case "fragile":
                    cars = cars
                        .Where(c => c.Cargo.CargoType == desiredCargo && c.Cargo.CargoWeight < 1000)
                        .ToList();
                    break;

                case "flamable":
                    cars = cars
                        .Where(c => c.Cargo.CargoType == desiredCargo && c.Engine.EnginePower > 250)
                        .ToList();
                    break;
            }

            foreach (var c in cars)
            {
                Console.WriteLine(c.Model);
            }
        }
    }

    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
        }



        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }
    }

    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }



        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }
    }

    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }



        public int CargoWeight { get; set; }

        public string CargoType { get; set; }
    }
}
