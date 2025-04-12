namespace Behavioral.Observer.Services
{
    internal class InvestorModifier : IBitcoinPriceObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine($"Investor's portfolio modified based on Bitcoin price: {price}");
        }
    }
}
