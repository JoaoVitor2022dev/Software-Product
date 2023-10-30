using System;
using System.Globalization;

namespace Primeiro.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Product Product { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderProduct { get; set; } = new List<OrderItem>();
        
        public Order(DateTime moment ,OrderStatus status ,Product product, Client client)
        {
           Moment = moment; 
           Status = status; 
           Product = product; 
           Client = client;
        }

        public void AddProduct(OrderItem product)
        {
           OrderProduct.Add(product);
        }

        public void RemoveProduct(OrderProduct product)
        {
           OrderProduct.Remove(product);
        }

        public double Total()
        {
           double sum = 0.0;
             
            foreach (OrderItem product in OrderProduct)
            {
                sum += product.subTotal();
            }

           return sum;  
        } 
    }
}







// product { infor, infor  } = pedidto do produttp {  infor, infor . meth somar o valor ( infor * infor  ) }

// order ( soma de todos os produtos )  