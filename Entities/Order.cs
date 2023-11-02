using System;
using System.Globalization;
using System.Collections.Generic;
using Primeiro.Entities.Enums;

namespace Primeiro.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        
        public Order(DateTime moment ,OrderStatus status , Client client )
        {
           Moment = moment; 
           Status = status; 
           Client = client;
        }

        public void AddItem(OrderItem item)
        {
           OrderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
           OrderItem.Remove(item);
        }

        public double Total()
        {
           double sum = 0.0;
             
            foreach (OrderItem prop in OrderItem)
            {
                sum += prop.subTotal();
            }
           return sum;  
        } 

        public override string ToString()
        {
           StringBuilder bs = new StringBuilder();
           sb.Append();
        }  
     }
}
