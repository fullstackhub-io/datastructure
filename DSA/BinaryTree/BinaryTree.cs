namespace BinaryTree
{
    internal class BinaryTree
    {
        private Node root;
        class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                this.Value = value;
            }

        }

        public void InsertRec(int item)
        {
            var node = new Node(item);
            InsertRec(root, node);
        }

        private void InsertRec(Node curr, Node newNode)
        {
            if (curr == null)
            {
                root = newNode;
                return;
            }
            else if (curr.Left == null)
            {
                curr.Left = newNode;
                return;
            }
            else if (curr.Right == null)
            {
                curr.Right = newNode;
                return;
            }

            if (root.Value > newNode.Value)
                InsertRec(curr.Left, newNode);
            else
                InsertRec(curr.Right, newNode);
        }

        public void Insert(int item)
        {
            var node = new Node(item);

            if (root == null)
            {
                root = node;
                return;
            }

            var current = root;

            while (true)
            {
                if (item > current.Value)
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                        break;
                    }
                    current = current.Right;
                }
                else if (item < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                        break;
                    }
                    current = current.Left;
                }
            }
        }

        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }

        private void TraversePreOrder(Node curr)
        {
            if (curr == null)
                return;

            Console.WriteLine(curr.Value);
            TraversePreOrder(curr.Left);
            TraversePreOrder(curr.Right);
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }

        private void TraverseInOrder(Node curr)
        {
            if (curr == null)
                return;

            TraversePreOrder(curr.Left);
            Console.WriteLine(curr.Value);
            TraversePreOrder(curr.Right);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }

        private void TraversePostOrder(Node curr)
        {
            if (curr == null)
                return;

            TraversePreOrder(curr.Left);
            TraversePreOrder(curr.Right);
            Console.WriteLine(curr.Value);
        }

        public int GetHeight()
        {
            return GetHeight(root);
        }

        private int GetHeight(Node curr)
        {
            if (curr == null)
                return -1;
            if (IsLeafNode(curr))
                return 0;

            return 1 + Math.Max(GetHeight(curr.Left), GetHeight(curr.Right));

        }

        private bool IsLeafNode(Node node)
        {
            return node.Left == null && node.Right == null;
        }
    }
}
