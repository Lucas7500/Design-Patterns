namespace Behavioral.Observer.APIs
{
    internal class BinanceAPI
    {
        public decimal GetLastPrice()
        {
            // Simulates a Binance request to retrieve Bitcoin's latest price

            const decimal minPrice = 50000;
            const decimal maxPrice = 100000;

            var rng = new Random();
            var range = (double)(maxPrice - minPrice);
            var sample = rng.NextDouble(); // 0.0 to 1.0
            
            return minPrice + (decimal)(sample * range);
        }
    }
}
