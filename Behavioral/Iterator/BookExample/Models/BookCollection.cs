using Behavioral.Iterator.BookExample.Interfaces;

namespace Behavioral.Iterator.BookExample.Models
{
    internal class BookCollection : IBookCollection
    {
        private readonly List<string> _titles = [];
        
        public void Add(string title)
        {
            _titles.Add(title);
        }

        public IBookIterator CreateIterator()
        {
            return new BookIterator(this);
        }
        
        public int Count => _titles.Count;
        
        public string this[int index]
        {
            get { return _titles[index]; }
        }
    }
}
