using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();

            string firstName = string.Empty;
            string lastName = string.Empty;
            int age = 0;
            string towns = string.Empty;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] cmd = command.Split();

                firstName = cmd[0];
                lastName = cmd[1];
                age = int.Parse(cmd[2]);
                towns = cmd[3];

                Student st = new Student();

                st.FirstName = firstName;
                st.LastName = lastName;
                st.Age = age;
                st.Hometown = towns;

                student.Add(st);
            }


            string town = Console.ReadLine();

            foreach (var st in student)
            {
                if (town == st.Hometown)
                {
                    if (IsExistStudent(student, firstName, lastName))
                    {
                        Student students = GetStudent(student, firstName, lastName);

                        students.FirstName = firstName;
                        students.LastName = lastName;
                        students.Age = age;
                        students.Hometown = towns;
                    }
                    else
                    {
                        Student students = new Student()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Age = age,
                            Hometown = town
                        };

                        student.Add(students);
                    }
                    
                }

                Console.WriteLine($"{st.FirstName} {st.LastName} is {st.Age} years old.");
            }
        }

        private static Student GetStudent(List<Student> student, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (var item in student)
            {
                if (item.FirstName == firstName && item.LastName == lastName)
                {
                    existingStudent = item;
                }
            }

            return existingStudent;
        }

        private static bool IsExistStudent(List<Student> students, object firstName, object lastName)
        {
            foreach (var item in students)
            {
                if (item.FirstName == firstName && item.LastName == lastName)
                {
                    return false;
                }
                
            }

            return true;
        }
    }
}
