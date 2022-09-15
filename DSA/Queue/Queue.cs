//Enqueue
//Dequeue
//Peek
//IsEmpty
//IsFull

namespace Queue
{
    internal class Queue<e> : IQueue<e>
    {
        private readonly e[] queue;
        private int queueIndex;
        private int current;

        public Queue(int size)
        {
            queue = new e[size];
            queueIndex = 0;
            current = 0;
        }

        public e Dequeue()
        {
            return queue[current++];
        }

        public void Enqueue(e value)
        {
            if (!IsFull())
            {
                queue[queueIndex++] = value;
            }
            else
            {
                throw new Exception("Queue is full");
            }
        }

        public bool IsEmpty()
        {
            return queue.Length == 0;
        }

        public bool IsFull()
        {
            return queueIndex > queue.Length - 1;

        }

        public e Peek()
        {
            return queue[current];
        }

        public void Print()
        {
            for (int i = current; i < queueIndex; i++)
            {
                Util.WriteDebug(Convert.ToString(queue[i]));
            }
        }
    }

    internal interface IQueue<e>
    {
        void Enqueue(e value);
        e Dequeue();
        e Peek();
        bool IsEmpty();
        bool IsFull();
        void Print();
    }
}
