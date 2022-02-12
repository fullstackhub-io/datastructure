//From Leetcode
//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.


//Example 1:

//Input: s = "()"
//Output: true

//Example 2:

//Input: s = "()[]{}"
//Output: true

//Input: s = "(]"
//Output: false

namespace ValidParentheses
{
    internal static class ValidParentheses
    {
        public static void IsValidParentheses(string expr)
        {

            Util.WriteDebug("Function Start");
            Util.WriteResult($"Is \"{expr}\" contains balanced Parentheses: {Solution1(expr)}");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static bool Solution1(string expr)
        {
            Util.WriteDebug("If expression contain opeartors from start opeartors list, push them in stack");
            Util.WriteDebug("If expression contain opeartors from end opeartors list, get the peak operator from stack");
            Util.WriteDebug("Make sure that peak operator has equivalent end operator by looping through the end operator or start operator array");

            Stack<char> stack = new();
            char[] startOps = new char[] { '(', '{', '[' };
            char[] endOps = new char[] { ')', '}', ']' };

            foreach (var oprtr in expr)
            {
                if (startOps.Contains(oprtr))
                {
                    stack.Push(oprtr);
                }
                else if (endOps.Contains(oprtr))
                {
                    char currentStackOpr = stack.Peek();

                    for (int i = 0; i < endOps.Length; i++)
                    {
                        if (currentStackOpr == startOps[i] && oprtr == endOps[i])
                            stack.Pop();
                    }
                        
                }
            }

            return stack.Count == 0;
        }
    }
}
