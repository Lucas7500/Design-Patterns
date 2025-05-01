namespace Behavioral.Iterator.Models
{
    internal class Node(int data)
    {
        public int Label { get; set; } = data;
        public Node? Left { get; set; } = null;
        public Node? Right { get; set; } = null;

        public void AddNode(Node root)
        {
            if (root is null)
            {
                Console.WriteLine("Could not call 'AddNode' because root was null");
                return;
            }
            
            if (root.Label == Label)
            {
                Console.WriteLine("Duplicate values not allowed");
                return;
            }
            
            if (Label < root.Label)
            {
                AddInLeftNode(root);
                return;
            }

            if (Label > root.Label)
            {
                AddInRightNode(root);
                return;
            }
        }

        private void AddInLeftNode(Node root)
        {
            if (root.Left is not null)
            {
                AddNode(root.Left);
                return;
            }
         
            Console.WriteLine("Added " + Label + " to the left of " + root.Label);
            root.Left = this;
        }
        
        private void AddInRightNode(Node root)
        {
            if (root.Right is not null)
            {
                AddNode(root.Right);
                return;
            }
         
            Console.WriteLine("Added " + Label + " to the right of " + root.Label);
            root.Right = this;
        }
    }
}
