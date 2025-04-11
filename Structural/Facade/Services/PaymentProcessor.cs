namespace Structural.Facade.Services
{
    internal class PaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} processed");
        }
    }
}
