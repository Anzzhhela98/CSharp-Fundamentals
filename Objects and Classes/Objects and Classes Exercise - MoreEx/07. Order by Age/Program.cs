using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Persons> infoPerPerson = new List<Persons>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command
                         .Split(" ")
                         .ToArray();
                Persons person = new Persons(input[0],
                    input[1], int.Parse(input[2]));
                infoPerPerson.Add(person);
            }
            infoPerPerson = infoPerPerson.OrderBy(a => a.Age).ToList();
            foreach (var perosn in infoPerPerson)
            {
                Console.WriteLine(perosn.ToString());
            }

        }
        class Persons
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
            public Persons(string name, string id, int age)
            {
                this.Name = name;
                this.Age = age;
                this.ID = id;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{this.Name} with ID:" +
                    $" {this.ID} is {this.Age} years old.");
                return sb.ToString();
            }
        }
    }
}
