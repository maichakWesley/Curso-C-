using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;
using Course.Entities.Enums;

namespace Aula29 //Enumeração e composição usando herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
         Order order = new Order{
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PedingPayment
         };

         Console.WriteLine(order);

         string txt = OrderStatus.PedingPayment.ToString();

         OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

         Console.WriteLine(txt);
         Console.WriteLine(os);
        }    
    }
}
