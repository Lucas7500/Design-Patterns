using Behavioral.Iterator.Models;

namespace Behavioral.Iterator.Interfaces
{
    internal interface INodeCollection
    {
        int Count();
        Node First();
        Node? FirstOrDefault();
        void Add(Node root);
        INodeIterator CreateIterator();
        INodeCollection SetTraversalType(ITraversalType traversalType);
    }
}
