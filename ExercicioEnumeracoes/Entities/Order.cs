using System;
using Course.Entities.Enums;
using Course.Entities;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    class Order
    {
        public DateTime Date {get; set;}
        public OrderStatus OrderStatus {get; set;}
        public Client Client { get; set; }
        public List<OrderItem> OrderItens {get; set;} = new List<OrderItem>();

        public Order(){

        }

        public Order(DateTime date, OrderStatus orderStatus, Client client){
            Date = date;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddClient(OrderItem item){
            OrderItens.Add(item);
        }

        public void RemoveClient(OrderItem item){
           OrderItens.Remove(item);
        }

        public double Total(){
            double sum = 0.0;
             
             foreach(OrderItem item in OrderItens){
                sum += item.SubTotal();
             }
             return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + OrderStatus);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }




    }
}