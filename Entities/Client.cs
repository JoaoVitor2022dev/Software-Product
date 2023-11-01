using System;
using System.Globalization;

namespace  Primeiro.Entities
{
    class Client
    {
         public string Name { get; set; }
         public string Email { get; set; }
         public DateTime Birth { get; set; } 

         public Client()
         {}

         public Client(string name, string email, DateTime birth)
         {
            Name = name; 
            Email = email; 
            Birth = birth; 
         }
    }
}