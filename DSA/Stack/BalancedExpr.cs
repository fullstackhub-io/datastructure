//Input: exp = “[()] { }
//{ [()()]()}” 
//Output: Balanced

//Input: exp = “[(])” 
//Output: Not Balanced

namespace CustomStack
{
    internal class BalancedExpr
    {
        public bool IsBalancedExpr(string expr)
        {
           List<char> startExpr = new() { '[', '(', '{' };
            List<char> endExpr = new() { ']', ')', '}' };

            CustomStack.Stack<char> stack = new(expr.Length);

            foreach (char c in expr)
            {
                if (startExpr.Contains(c))
                {
                    stack.Push(c);
                }
                else if (endExpr.Contains(c))
                {
                    var top = stack.Pop();

                    if (startExpr.IndexOf(top) != endExpr.IndexOf(c))
                        return false;
                }
            }

            return stack.IsEmpty();
        }
    }
}
