using System;
using System.Globalization;
using Primeiro.Entities;
using Primeiro.Entities.Enums;

namespace Primeiro
{
    class Program
    {
        static void Main()
        {
           // entrada de dados 
           Console.WriteLine("Enter Client data"); 
          
            Console.Write("Name: ");
            string name = Console.ReadLine();
           
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            // instaciando os dados do cliente  
            Client client = new Client(name, email, birthDate);

            // segunda parte de entrada de dados
            
            Console.WriteLine("Enter order data");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()); 

            DateTime moment = DateTime.Now; 

            Order order = new Order(moment, status, client);
            
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} tem data: "); 

                Console.Write("Product name: "); 
                string nameProduct = Console.ReadLine();

                Console.Write("Product price: "); 
                double price = double.Parse(Console.ReadLine());

                Console.Write("Product Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, price);
               
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem); 
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
       }
   }
}

