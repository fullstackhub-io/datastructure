
namespace CustomStack
{
    internal class MinStack
    {
        private readonly CustomStack.Stack<int> stack;
        private int minValue;

        public MinStack(int[] arr)
        {
            stack = new Stack<int>(arr.Length);
            foreach (var item in arr)
            {
                stack.Push(item);
            }
        }

        public int GetMinValue()
        {
            minValue = stack.Peak();
            while (!stack.IsEmpty())
            {
              var top = stack.Pop();
              if (minValue > top)
                {
                    minValue = top;
                }
            }

            return minValue;
        }

    }
}
