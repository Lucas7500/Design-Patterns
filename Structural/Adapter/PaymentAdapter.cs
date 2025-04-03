using Structural.Adapter.Interfaces;
using Structural.Adapter.Services;

namespace Structural.Adapter
{
    internal class PaymentAdapter(OldPaymentSystem oldPaymentSystem) : IPaymentProcessor
    {
        public void ProcessPayment(string accountNumber, decimal amount)
        {
            var convertedAmount = Convert.ToDouble(amount);
            oldPaymentSystem.MakePayment(accountNumber, convertedAmount);
        }
    }
}
