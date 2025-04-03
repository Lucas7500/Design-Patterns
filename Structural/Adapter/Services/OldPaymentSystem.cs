namespace Structural.Adapter.Services
{
    internal class OldPaymentSystem
    {
        public void MakePayment(string cardNumber, double amount)
        {
            Console.WriteLine($"Processing payment of {amount} using card {cardNumber} via the old system.");
        }
    }
}
