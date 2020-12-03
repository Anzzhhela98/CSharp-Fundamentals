using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Box> boxes = new List<Box>();
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> splitted = command
                      .Split(" ")
                      .ToList();
                string number = splitted[0];
                string nameOfItem = splitted[1];
                int quantity = int.Parse(splitted[2]);
                double pricePerItem = double.Parse(splitted[3]);

                Box box = new Box()
                {
                    SerialNumber = number,
                    product = nameOfItem,
                    ItemQuantity = quantity,
                    Price = pricePerItem,
                    AllPrice = quantity * pricePerItem
                };
                boxes.Add(box);
            }
            boxes = boxes.OrderByDescending(p => p.AllPrice).ToList();
            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.product} - ${box.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.AllPrice:f2}");
            }

        }
     
        public class Box
        {
            public string SerialNumber { get; set; }
            public string product { get; set; }
            public int ItemQuantity { get; set; }
            public double AllPrice { get; set; }
            public double Price { get; set; }
        }
    }
}
