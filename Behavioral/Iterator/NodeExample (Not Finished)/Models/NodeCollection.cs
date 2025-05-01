using Behavioral.Iterator.Interfaces;

namespace Behavioral.Iterator.Models
{
    internal class NodeCollection : INodeCollection
    {
        private ITraversalType? _traversalType = null;
        private Node? _root = null;

        /// <summary>
        /// Returns the number of nodes in the collection based on the current traversal strategy.
        /// </summary>
        /// <returns>The number of nodes.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the traversal type has not been set.
        /// </exception>
        public int Count()
        {
            if (_traversalType is null)
            {
                throw new InvalidOperationException("You must set the traversal type before counting the collection!");
            }

            return _traversalType.Count(_root);
        }

        /// <summary>
        /// Returns the first element of the collection;
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public Node First()
        {
            if (_root is null)
            {
                throw new InvalidOperationException("There is no element on this collection!");
            }

            return _root;
        }

        /// <summary>
        /// Returns the first element of the collection, or a default value if the collection contains no elements.
        /// </summary>
        /// <returns></returns>
        public Node? FirstOrDefault()
        {
            return _root;
        }

        /// <summary>
        /// Adds a node to the collection.
        /// </summary>
        /// <param name="root">The node to add.</param>
        public void Add(Node root)
        {
            if (_root is null)
            {
                _root = root;
                return;
            }

            _root.AddNode(root);
        }

        /// <summary>
        /// Creates an iterator for traversing the collection based on the current traversal strategy.
        /// </summary>
        /// <returns>An <see cref="INodeIterator"/> for the collection.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the traversal type has not been set.
        /// </exception>
        public INodeIterator CreateIterator()
        {
            if (_traversalType is null)
            {
                throw new InvalidOperationException("You must set the traversal type before creating the Iterator!");
            }

            return new NodeIterator(this, _traversalType);
        }

        /// <summary>
        /// Sets the traversal strategy to be used by this collection.
        /// </summary>
        /// <param name="traversalType">The traversal strategy implementation.</param>
        /// <returns>The current <see cref="INodeCollection"/> instance.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the provided traversal type is null.
        /// </exception>
        public INodeCollection SetTraversalType(ITraversalType traversalType)
        {
            if (traversalType is null)
            {
                throw new InvalidOperationException("The traversal type can't be null!");
            }

            _traversalType = traversalType;

            return this;
        }
    }
}
