namespace Behavioral.Observer.Services
{
    internal class BitcoinPriceLogger : IBitcoinPriceObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine($"Bitcoin price logged: {price}");
        }
    }
}
