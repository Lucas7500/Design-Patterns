using Behavioral.Iterator.Interfaces;
using Behavioral.Iterator.Models;

namespace Behavioral.Iterator.TraversalTypes
{
    internal class InOrderTraversal : ITraversalType
    {
        public int Count(Node? root)
        {
            if (root is null) return 0;

            var count = 0;
            var current = root;

            while (current is not null)
            {
                count++;
                current = Next(current);
            }

            return count;
        }

        public Node? Next(Node? root)
        {
            throw new NotImplementedException();
        }

        public Node NodeAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
