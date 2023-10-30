using System;
using System.Globalization;

namespace Primeiro.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {}
        public OrderItem(int quantity, double price)
        {
            Quantity = quantity; 
            Price = price;
        }

        public double subTotal()
        {
           return Quantity * Price;
        }
    }
}