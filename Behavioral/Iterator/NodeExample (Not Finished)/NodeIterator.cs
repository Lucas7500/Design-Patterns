using Behavioral.Iterator.Interfaces;
using Behavioral.Iterator.Models;

namespace Behavioral.Iterator
{
    internal class NodeIterator(NodeCollection collection, ITraversalType traversal) : INodeIterator
    {
        private Node? _current = collection.FirstOrDefault();

        public bool HasNext()
        {
            if (_current is null)
            {
                return false;
            }

            return _current.Left is not null || _current.Right is not null;
        }

        public Node? Next()
        {
            var nextNode = traversal.Next(_current);
            _current = nextNode;
            return nextNode;
        }
    }
}
