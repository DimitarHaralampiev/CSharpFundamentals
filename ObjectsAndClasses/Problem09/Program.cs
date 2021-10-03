using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem09
{
    public class Student
    {

        public string FirstName { get; set; }


        public int ID { get; set; }


        public int Age { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listSt = new List<Student>();

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "End")
                {
                    break;
                }

                string[] command = cmd.Split();

                Student student = new Student()
                {
                    FirstName = command[0],
                    ID = int.Parse(command[1]),
                    Age = int.Parse(command[2])
                };

                listSt.Add(student);
            }

            foreach (var item in listSt)
            {
                List<Student> students = listSt
                    .OrderBy(x => x.Age)
                    .ToList();

                foreach (var items in students)
                {
                    Console.WriteLine($"{items.FirstName} with ID: {items.ID} is {items.Age} years old.");
                }

                break;
            }
        }
    }
}
