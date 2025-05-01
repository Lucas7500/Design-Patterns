namespace Behavioral.Iterator.BookExample.Interfaces
{
    internal interface IBookIterator
    {
        public string First();
        public string? Next();
        public bool IsDone();
        public string Current();
    }
}
