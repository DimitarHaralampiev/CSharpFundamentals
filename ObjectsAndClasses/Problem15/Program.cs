using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem15
{
    public class Student
    {

        public string FirstName { get; set; }


        public string LastName { get; set; }


        public double Grade { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> student = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ");

                string firstName = command[0];
                string lastName = command[1];
                double grade = double.Parse(command[2]);

                Student student1 = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                student.Add(student1);
            }

            List<Student> list = student
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:F2}");
            }
        }
    }
}
