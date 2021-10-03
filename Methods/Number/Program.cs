using System;
using System.Numerics;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string rev = null;
            for(int i = str.Length - 1; i >= 0;i--)
            {
                rev += str[i];
            }
            Console.Write(rev);
            Console.WriteLine();

            int[] num = { 4, 5, 5, 5, 5, 5, 5, 4, 4, 7, 4, 4, 5, 4, 1};
            Console.Write("Enter numbers: ");

            int numbers = int.Parse(Console.ReadLine());
            //for(int i = 0; i < num.Length;i++)
            int count = Number(numbers, num);
            Console.WriteLine(count);

            Console.WriteLine();

            Console.Write("Enter possition element ");
            int postEleemnt = int.Parse(Console.ReadLine());
            Element(num, postEleemnt);

            Console.WriteLine();

            Console.Write("Please enter number: ");
            string number = Console.ReadLine();
            Reverse(number);

            Console.WriteLine();

            Sort(num);

            Console.WriteLine();

            BigInteger res = Fact(100);
            Console.WriteLine(res);
        }

        public static int Number(int numb, int[] arr)
        {
            int counter = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                if(numb == arr[i])
                {
                    counter++;
                }
            }
            return counter;
        }
        public static void Element(int[] num, int posElement)
        {
            for(int i = 0;i < num.Length;i++)
            {
                //num[i] = posElement;
                if(posElement == i)
                {
                    //num[i] = posElement;
                    if (num[posElement] > num[i + 1] && num[posElement] > num[i - 1])
                    {
                        Console.WriteLine($"Number of possition {posElement} is large of next element and back element ");
                        break;
                    }
                    else if (num[posElement] < num[i + 1] && num[posElement] > num[i - 1])
                    {
                        Console.WriteLine($"Number of possition {posElement} is small of next element and large of back element ");
                        break;
                    } 
                    else if (num[posElement] > num[i + 1] && num[posElement] < num[i - 1])
                    {
                        Console.WriteLine($"Number of possition {posElement} is large of next element and small of back element ");
                        break;
                    }else
                    {
                        Console.WriteLine("Element of possition is equal large and small element");
                    }
                }
            }
        }

        public static void Reverse(string num)
        {
            //string reverse = string.Empty;
           // for(int i = 0; i < num.Length;i++)
          //  {
          //      Console.Write(num[i].ToString());
          //  }

           // Console.WriteLine();
            char[] ch = num.ToCharArray();

            for(int i = ch.Length - 1; i >= 0;i--)
            {
                Console.Write(ch[i]);
            }
            //Console.Write(reverse);
        }

        public static void Sort(int[] num)
        {
            int temp = 0;
            for(int i = 0; i < num.Length;i++)
            {
                for(int j = 0; j < num.Length;j++)
                {
                    if(num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            for(int i = num.Length - 1; i > 0;i--)
            {
                Console.Write(num[i] + " ");
            }
        }

        public static BigInteger Fact(int bigNum)
        {
            //int sum = 1;
            BigInteger fact = 1;
            for(int i = 1; i <= bigNum;i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
        


