using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sumPriceBox = 0;

            string serialNumber = string.Empty;
            string itemName = string.Empty;
            int itemQuatity = 0;
            decimal itemPrice = 0;

            List<Box> listSum = new List<Box>();
            List<decimal> list = new List<decimal>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] command = line.Split();

                serialNumber = command[0];
                itemName = command[1];
                itemQuatity = int.Parse(command[2]);
                itemPrice = decimal.Parse(command[3]);

                sumPriceBox = itemQuatity * itemPrice;

                Box box = new Box();
                box.Item = new Item();

                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.Quantity = itemQuatity;
                box.PriceForBox = itemPrice;

                listSum.Add(box);
                list.Add(sumPriceBox);
            }
            PrintAll(listSum, serialNumber, itemName, itemQuatity, itemPrice);
        }

        private static void PrintAll(List<Box> listSum, string serialNumber, string itemName, int itemQuatity, decimal itemPrice)
        {
            foreach (var item in listSum)
            {
                Console.WriteLine($"{item.SerialNumber} \n -- {item.Item.Name} - ${item.Quantity}: {item.PriceForBox:F2}\n -- {SumPriceBox(item.Quantity, item.PriceForBox):F2}");
            }
        }

        private static decimal SumPriceBox(decimal quantity, decimal priceForBox)
        {
            decimal sort = quantity * priceForBox;
       
            return sort;         
        }
    }
}
