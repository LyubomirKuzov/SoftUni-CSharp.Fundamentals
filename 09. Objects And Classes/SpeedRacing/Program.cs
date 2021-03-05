using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
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
                double fuelAmount = double.Parse(carArgs[1]);
                double fuelConsumption = double.Parse(carArgs[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "End")
                {
                    break;
                }

                string carModel = command[1];
                double distanceToTravel = double.Parse(command[2]);

                Car car = cars.First(c => c.Model == carModel);
                car.Travel(distanceToTravel);
            }

            foreach (var c in cars)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }

    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.TravelDistance = 0;
        }



        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelDistance { get; set; }



        private bool CanCarTravelTheDistance(double distanceToTravel)
        {
            double fuelNeeded = CalculateFuelNeeded(distanceToTravel);

            return this.FuelAmount >= fuelNeeded;
        }

        private double CalculateFuelNeeded(double distanceToTravel)
        {
            return distanceToTravel * this.FuelConsumptionPerKilometer;
        }

        public void Travel(double distanceToTravel)
        {
            if (CanCarTravelTheDistance(distanceToTravel))
            {
                double fuelNeeded = CalculateFuelNeeded(distanceToTravel);

                this.FuelAmount -= fuelNeeded;
                this.TravelDistance += distanceToTravel;
            }

            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TravelDistance}";
        }
    }
}
