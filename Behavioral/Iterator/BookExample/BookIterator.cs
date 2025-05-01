using Behavioral.Iterator.BookExample.Interfaces;
using Behavioral.Iterator.BookExample.Models;

namespace Behavioral.Iterator.BookExample
{
    internal class BookIterator(BookCollection books) : IBookIterator
    {
        private int _current = 0;

        public string First()
        {
            return books[0];
        }

        public string? Next()
        {
            _current++;

            if (IsDone())
            {
                return null;
            }
        
            return books[_current];
        }

        public bool IsDone()
        {
            return _current >= books.Count;
        }

        public string Current()
        {
            return books[_current];
        }
    }
}
