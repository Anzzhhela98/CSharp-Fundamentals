using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Catalog catalog = new Catalog();
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> splitted = command
                     .Split("/")
                     .ToList();
                if (splitted[0] == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = splitted[1],
                        Model = splitted[2],
                        HoursePower = int.Parse(splitted[3])

                    };
                    catalog.ListCar.Add(car);
                }
                else
                {
                    Truck truck = new Truck()
                    {
                        Brand = splitted[1],
                        Model = splitted[2],
                        Weight = int.Parse(splitted[3])

                    };
                    catalog.ListTruck.Add(truck);
                }
            }
            if (catalog.ListCar.Count != 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car car in catalog.ListCar.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
                }
            }
            if (catalog.ListTruck.Count != 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truck in catalog.ListTruck.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
        public class Catalog
        {
            public Catalog()
            {
                this.ListCar = new List<Car>();
                this.ListTruck = new List<Truck>();
            }
            public List<Truck> ListTruck { get; set; }
            public List<Car> ListCar { get; set; }
        }
        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HoursePower { get; set; }
        }

    }
}
