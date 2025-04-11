using Structural.Facade.Models;
using Structural.Facade.Services;

namespace Structural.Facade
{
    internal class OrderFacade(
        PaymentProcessor paymentProcessor, 
        Notifier notifier,
        InventoryManager inventoryManager,
        ShippingService shippingService)
    {
        public void ProcessOrder(OrderDetails orderDetails)
        {
            paymentProcessor.ProcessPayment(orderDetails.Amount);
            notifier.SendConfirmation(orderDetails.Email);
            inventoryManager.UpdateStock(orderDetails.ProductId, orderDetails.Quantity);
            shippingService.InitiateShipping(orderDetails);
        }
    }
}
