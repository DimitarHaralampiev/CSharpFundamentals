using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem08
{
    public class Student
    {
        public string FirstName { get; set; }


        public string LastName { get; set; }


        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> student = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split();

                string firstName = arr[0];
                string lastName = arr[1];
                double grade = double.Parse(arr[2]);

                Student st = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                student.Add(st);
            }

            foreach (var item in student)
            {
                List<Student> listStudent = student
                    .OrderByDescending(x => x.Grade)
                    .ToList();

                foreach (var items in listStudent)
                {
                    Console.WriteLine($"{items.FirstName} {items.LastName}: {items.Grade:F2}");
                }

                break;
            }
        }
    }
}
