using Behavioral.Iterator.Models;

namespace Behavioral.Iterator.Interfaces
{
    internal interface INodeIterator
    {
        bool HasNext();
        Node? Next();
    }
}
