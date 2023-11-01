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

            // segunda parte de entrada de dados 

            Console.WriteLine("Enter order data");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()); 

            DateTime moment = DateTime.Now; 
            
            // instaciando os dados do cliente  
            Client client = new Client(name, email, birth);

            // estaciando o pedido e juntando o relacionamento com a classe Client 
            Order order = new Order(moment, status, client);

            // entrada de dados dos contratos
            
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #1 tem data: "); 

                Console.Write("Product name: "); 
                string name = Console.ReadLine();

                Console.Write("Product price: "); 
                double price = double.Parse(Console.ReadLine());

                Console.Write("Product Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
               
                Product product = new Product(name, price, quantity);

                order.AddProduct(product); 
            }
        }
   }
}

