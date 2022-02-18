//Given an integer n, return true if it is a power of two. Otherwise, return false.

//An integer n is a power of two, if there exists an integer x such that n == 2x.

 

//Example 1:

//Input: n = 1
//Output: true
//Explanation: 20 = 1
//Example 2:

//Input: n = 16
//Output: true
//Explanation: 24 = 16
//Example 3:

//Input: n = 3
//Output: false

namespace PowerofTwo
{
    internal static class PowerOfTwo
    {
        public static void IsPowerOfTwo(int num)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"Is {num} power of two: '{ Solution1(num)}'");
            Util.WriteResult($"Is {num} power of two: '{ Solution2(num)}'");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static bool Solution1(int num)
        {
          
            while (num != 2)
            {
                if (num % 2 != 0)
                    return false;
                else
                {
                    num /= 2;
                }
            }

            return true;
        }

        private static bool Solution2(int num)
        {
            int multiple = 1;

            while (multiple < num)
            {
                multiple *= 2;
            }

            return multiple == num;
        }
    }
}