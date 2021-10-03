using System;
using System.Collections.Generic;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> keyValuePairs = new Dictionary<string, decimal>();
            Dictionary<string, int> quantityByPrice = new Dictionary<string, int>();

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "buy")
                {
                    break;
                }

                string[] cmd = product.Split();

                string products = cmd[0];
                decimal price = decimal.Parse(cmd[1]);
                int quantity = int.Parse(cmd[2]);

                if (keyValuePairs.ContainsKey(products))
                {
                    quantityByPrice[products] += quantity;
                    keyValuePairs[products] = price;
                }
                else
                {
                    keyValuePairs.Add(products, price);
                    quantityByPrice.Add(products, quantity);
                }
            }

            foreach (var kvp in keyValuePairs)
            {
                string product = kvp.Key;
                decimal price = kvp.Value;
                int quantity = quantityByPrice[product];

                decimal totalPrice = quantity * price;

                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }
        }
    }
}
