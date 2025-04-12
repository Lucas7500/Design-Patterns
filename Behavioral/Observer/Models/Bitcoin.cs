namespace Behavioral.Observer.Models
{
    internal class Bitcoin
    {
        private decimal _price;
        private readonly ICollection<IBitcoinPriceObserver> _observers = [];

        public decimal Price 
        {
            get => _price;
            set
            {
                if (value != _price)
                {
                    _price = value;

                    NotifyObservers();
                }
            }
        }

        public void AddObserver(IBitcoinPriceObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IBitcoinPriceObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_price);
            }
        }
    }
}
