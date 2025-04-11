using Structural.Facade.Models;

namespace Structural.Facade.Services
{
    internal class ShippingService
    {
        public void InitiateShipping(OrderDetails orderDetails)
        {
            Console.WriteLine($"Shipping initiated for order {orderDetails.Id} to address: {orderDetails.Address}");
        }
    }
}
