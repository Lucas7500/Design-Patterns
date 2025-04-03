using Structural.Adapter.Interfaces;

namespace Structural.Adapter.Services
{
    internal class ECommercePlatform(IPaymentProcessor paymentProcessor)
    {
        public void Checkout(string accountNumber, decimal amount)
        {
            paymentProcessor.ProcessPayment(accountNumber, amount);
        }
    }
}
