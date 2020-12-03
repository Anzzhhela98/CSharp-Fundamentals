using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentsGrade.ContainsKey(name))
                {
                    studentsGrade[name] = new List<double>();
                    studentsGrade[name].Add(grade);
                }
                else
                {
                    studentsGrade[name].Add(grade);
                }
            }
            foreach (var item in studentsGrade)
            {
                var rezult = item.Value.Average();
                if (rezult < 4.50)
                {
                    studentsGrade.Remove(item.Key);
                }
            }
            foreach (var item in studentsGrade.OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
