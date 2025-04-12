namespace Behavioral.Observer
{
    internal interface IBitcoinPriceObserver
    {
        void Update(decimal price);
    }
}
