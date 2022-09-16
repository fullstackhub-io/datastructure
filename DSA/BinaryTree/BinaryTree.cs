namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public class Node
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
            InsertRec(Root, node);
        }

        private void InsertRec(Node curr, Node newNode)
        {
            if (curr == null)
            {
                Root = newNode;
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

            if (Root.Value > newNode.Value)
                InsertRec(curr.Left, newNode);
            else
                InsertRec(curr.Right, newNode);
        }

        public void Insert(int item)
        {
            var node = new Node(item);

            if (Root == null)
            {
                Root = node;
                return;
            }

            var current = Root;

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
            TraversePreOrder(Root);
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
            TraverseInOrder(Root);
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
            TraversePostOrder(Root);
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
            return GetHeight(Root);
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

        public bool IsEqual(BinaryTree other)
        {
            return IsEqual(Root, other.Root);
        }

        private bool IsEqual(Node first, Node second)
        {
            if (first == null && second == null)
                return true;

            return first.Value == second.Value &&
                   IsEqual(first.Left, second.Left) &&
                   IsEqual(first.Right, second.Right);
        }

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(Root, int.MinValue, int.MaxValue);
        }

        private bool IsBinarySearchTree(Node node, int min, int max)
        {
            if (node == null)
                return true;

            if (Root.Value < min && Root.Value > max)
                return false;

            return IsBinarySearchTree(Root.Left, min, Root.Value - 1) &&
                   IsBinarySearchTree(Root.Right, Root.Value + 1, max);
        }
    }
}
