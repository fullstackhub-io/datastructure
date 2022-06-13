//Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

//Note that after backspacing an empty text, the text will continue empty.


//Example 1:
//Input: s = "ab#c", t = "ad#c"
//Output: true
//Explanation: Both s and t become "ac".

//Example 2:
//Input: s = "ab##", t = "c#d#"
//Output: true
//Explanation: Both s and t become "".

//Example 3:
//Input: s = "a#c", t = "b"
//Output: false
//Explanation: s becomes "c" while t becomes "b".

namespace BackspaceStrCompr
{
    internal static class BackspaceStringComparer
    {
        public static void GetBackspaceStrCompr(string str1, string str2)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"Are two strings \"{str1}\" & \"{str1}\" after backspacing equal: { Solution1(str1, str2)}");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static bool Solution1(string str1, string str2)
        {
            Util.WriteDebug("Create two stacks, simply insert each character of string");
            Util.WriteDebug("If the character is #, pop the previous character from stack");
            Util.WriteDebug("After populating both stacks, compare their content if both are equal");

            Stack<char> stackStr1 = new();
            Stack<char> stackStr2 = new();

            PopulateStack(stackStr1, str1);
            PopulateStack(stackStr2, str2);

            while (stackStr1.Count > 0)
            {
                char curr = stackStr1.Pop();

                if (stackStr2.Count == 0 || stackStr2.Pop() != curr)
                {
                   return false;
                }
            }

            return stackStr1.Count == 0 && stackStr2.Count == 0;
        }

        private static void PopulateStack(Stack<char> stack, string str1)
        {
            foreach (char c in str1)
            {
                if (c == '#')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
        }

    }
}
