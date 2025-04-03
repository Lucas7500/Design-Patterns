namespace Structural.Adapter.Interfaces
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(string accountNumber, decimal amount);
    }
}
