// Push(), Pop(), Peak(), IsEmpty()

namespace CustomStack
{
    internal class Stack<T>
    {
        readonly T[] arr;

        public Stack(int size)
        {
            arr = new T[size];
        }

        int count;

        public void Push(T item)
        {
            arr[count] = item;
            count++;
        }

        public T? Pop()
        {
            if (count > 0)
            {
                var item = arr[count - 1];
                count--;
                return item;
            }

            return default;
        }

        public T Peak()
        {
            return arr[count - 1];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
