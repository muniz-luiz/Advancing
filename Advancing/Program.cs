using Advancing.Entities.Enums;
using Advancing.Entities;


namespace Advancing

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.UtcNow,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

        }
    }
}