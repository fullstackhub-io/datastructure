// Custom Linked List

namespace LinkedList
{
    public class LinkedList
    {
        public int Count { get; set; }
        private Node head;
        private Node tail;

        public void InsertLast(int value)
        {
            Node newNode = new(value);

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }

            Count++;
        }

        public void InsertFirst(int value)
        {
            Node newNode = new(value);

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }

            Count++;
        }

        public void RemoveFirst()
        {
            // 12-> 30 -> 40

            head = head.next;
            Count--;
        }

        public void RemoveLast()
        {
            if (head == null)
                return;

            if (Count == 1)
                head = tail = null;
            else
            {
                tail = GetSecondLastNode();
                tail.next = null;
            }

            Count--;
        }

        private Node? GetSecondLastNode()
        {
            var curr = head;

            while (curr != null)
            {
                if (curr.next == tail)
                    return curr;
                else curr = curr.next;
            }

            return null;
        }

        public int IndexOf(int val)
        {
            var node = head;
            for (int i = 0; i < Count; i++)
            {
                if (node.Value == val)
                    return i;
                node = node.next;
            }
            return -1;
        }

        public int[] ConverttoArray()
        {
            var arr = new int[Count];

            var curr = head;

            for (int i = 0; i < Count; i++)
            {
                arr[i] = curr.Value;
                curr = curr.next;
            }

            return arr;
        }

        public void Reverse()
        {
            var prev = head;
            var curr = head.next;

            while (curr != null)
            {
                var nxt = curr.next;
                curr.next = prev;

                prev = curr;
                curr = nxt;
            }

            tail = head;
            tail.next = null;
            head = prev;

        }

        public void Print()
        {
            var node = head;
            while (node != null)
            {
                Util.WriteDebug(node.Value.ToString());
                node = node.next;
            }
        }

        class Node
        {
            private readonly int value;
            public Node next;

            public Node(int value) => this.value = value;

            public int Value
            {
                get { return value; }
            }
        }
    }
}
