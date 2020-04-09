using System;
using Enumeração.Entities;
namespace Enumeração
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.Id = 1080;
            order.Moment = DateTime.Now;
            order.Status = Entities.Enums.OrderStatus.PendingPayment;
            Console.WriteLine(order);
        }

        
    }
}
