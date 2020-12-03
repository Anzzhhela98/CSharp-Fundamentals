using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Student> saveStudent = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> students = input
                      .Split(" ")
                      .ToList();
                Student student = new Student();
                student.FirstName = students[0];
                student.LastName = students[1];
                student.Age = int.Parse(students[2]);
                student.HomeTown = students[3];
                saveStudent.Add(student);

            }
            string city = Console.ReadLine();
            saveStudent = saveStudent.Where(s => s.HomeTown == city).ToList();
            foreach (var student in saveStudent)
            {
                Console.WriteLine($"{student.FirstName}" +
                    $" {student.LastName} is {student.Age} years old.");

            }
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
