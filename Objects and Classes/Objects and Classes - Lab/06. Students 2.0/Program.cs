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
                string FirstName = students[0];
                string LastName = students[1];
                int Age = int.Parse(students[2]);
                string HomeTown = students[3];
                if (IsStudentExisting(saveStudent, FirstName, LastName))
                {
                    Student person = GetStudent(saveStudent, FirstName, LastName, Age, HomeTown);
                }
                else
                {
                    Student person = new Student();
                    person.FirstName = students[0];
                    person.LastName = students[1];
                    person.Age = int.Parse(students[2]);
                    person.HomeTown = students[3];
                    saveStudent.Add(person);
                }

            }
            string city = Console.ReadLine();
            saveStudent = saveStudent.Where(s => s.HomeTown == city).ToList();
            foreach (var person in saveStudent)
            {
                Console.WriteLine($"{person.FirstName}" +
                    $" {person.LastName} is {person.Age} years old.");

            }
        }

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
        static bool IsStudentExisting(List<Student> saveStudent,
             string firstName, string LastName)
        {
            foreach (Student person in saveStudent)
            {
                if (person.FirstName == firstName && person.LastName == LastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> student, string firstName,
            string lastName, int age, string hometown)
        {
            Student excistingStudent = null;
            foreach (Student person in student)
            {
                if (person.FirstName == firstName && person.LastName == lastName)
                {
                    person.Age = age;
                    person.HomeTown = hometown;
                }
            }
            return excistingStudent;
        }
    }
}
