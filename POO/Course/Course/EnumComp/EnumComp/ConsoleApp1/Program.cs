using ConsoleApp1.Entities;
using ConsoleApp1.Entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment           
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //Converte um enum para string
            Console.WriteLine(txt);

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");//Converte uma string para enum 
            Console.WriteLine(os);

            Console.ReadLine();
        }
    }
}
