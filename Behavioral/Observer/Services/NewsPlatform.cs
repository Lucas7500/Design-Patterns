namespace Behavioral.Observer.Services
{
    internal class NewsPlatform : IBitcoinPriceObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine($"News platform updated with Bitcoin price: {price}");
        }
    }
}
