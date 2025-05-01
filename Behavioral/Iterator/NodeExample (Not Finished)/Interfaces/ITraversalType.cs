using Behavioral.Iterator.Models;

namespace Behavioral.Iterator.Interfaces
{
    internal interface ITraversalType
    {
        int Count(Node? root);
        Node? Next(Node? root);
        Node NodeAt(int index);
    }
}
