using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Students> myListStudents = new List<Students>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console
                          .ReadLine()
                          .Split(" ")
                          .ToArray();
                Students myStudents = new Students(input[0], input[1],
                    double.Parse(input[2]));
                myListStudents.Add(myStudents);
            }
            myListStudents = myListStudents
                .OrderByDescending(g => g.Grade).ToList();
            myListStudents.ForEach(x => Console.WriteLine(x));
            //foreach (var studen in myListStudents)
            //{
            //    Console.WriteLine(studen.ToString());
            //}
        }
        class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
            public Students(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
