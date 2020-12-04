using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            string command = string.Empty;
            double averageCarPower = 0;
            double averageTruckPower = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command
                          .Split(" ")
                          .ToArray();
                Vehicle catalogVecle =
                    new Vehicle(input[0], input[1], input[2], double.Parse(input[3]));
                if (input[0] == "car")
                {
                    cars.Add(catalogVecle);
                    averageCarPower += double.Parse(input[3]);

                }
                else
                {
                    trucks.Add(catalogVecle);
                    averageTruckPower += double.Parse(input[3]);
                }

            }
            averageCarPower = averageCarPower / cars.Count;
            averageTruckPower = averageTruckPower / trucks.Count;
            string secondInput = string.Empty;

            while ((secondInput = Console.ReadLine()) != "Close the Catalogue")
            {
                if (cars.Any(x => x.Model.Contains(secondInput)))
                {
                    int index = cars.FindIndex(x => x.Model.Contains(secondInput));
                    Console.WriteLine(cars[index]);
                }
                else
                {
                    int index = trucks.FindIndex(x => x.Model.Contains(secondInput));
                    Console.WriteLine(trucks[index]);
                }
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarPower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckPower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
        class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
            public object StringBuilde { get; private set; }

            public Vehicle(string type, string model, string color, double horsepower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Type: {char.ToUpper(this.Type[0]) + Type.Substring(1)}");
                sb.AppendLine($"Model: {this.Model}");
                sb.AppendLine($"Color: {this.Color}");
                sb.AppendLine($"Horsepower: {this.Horsepower}");
                return sb.ToString().Trim();
            }
        }
    }
}
