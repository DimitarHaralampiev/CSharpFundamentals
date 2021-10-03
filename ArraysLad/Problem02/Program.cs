using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(ReceivesGrade(num));
        }

        static string ReceivesGrade(double num)
        {
            string str = string.Empty;

            if(num > 2 && num <= 2.99)
            {
                str = "Fail";
            }
            else if(num >= 3.00 && num <= 3.49)
            {
                str = "Poor";
            }
            else if(num >= 3.5 && num <= 4.49)
            {
                str = "Good";
            }
            else if(num >= 4.5 && num <= 5.49)
            {
                str = "Very good";
            }
            else if(num >= 5.50 && num <= 6)
            {
                str = "Excellent";
            }

            return str;
        }
    }
}
