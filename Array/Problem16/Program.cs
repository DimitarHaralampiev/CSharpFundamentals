using System;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int bonusPoints = int.Parse(Console.ReadLine());

            double maxBonusPoints = 0;
            int studentNumber = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                int student = int.Parse(Console.ReadLine());

                double totalPoints = (double)student / countOfLectures * (5 + bonusPoints);

                if (totalPoints > maxBonusPoints)
                {
                    maxBonusPoints = totalPoints;
                    studentNumber = student;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonusPoints)}.");

            Console.WriteLine($"The student has attended {studentNumber} lectures.");
        }
    }
}
