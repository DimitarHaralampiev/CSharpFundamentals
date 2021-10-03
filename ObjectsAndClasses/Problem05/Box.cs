using System;
using System.Collections.Generic;
using System.Text;

namespace Problem05
{
    public class Box
    {

        public Box()
        {
            Item = new Item();
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceForBox { get; set; }
    }
}
