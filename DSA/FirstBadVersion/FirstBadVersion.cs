//You are a product manager and currently leading a team to develop a new product.Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

//Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

//You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.



//Example 1:

//Input: n = 5, bad = 4
//Output: 4
//Explanation:
//call isBadVersion(3) -> false
//call isBadVersion(5) -> true
//call isBadVersion(4) -> true
//Then 4 is the first bad version.
//Example 2:

//Input: n = 1, bad = 1
//Output: 1

namespace FirstBadVersion
{
    internal static class FirstBadVersion
    {
        public static void GetFirstBadVersion(int n)
        {
            
            Util.WriteDebug("Function Start");
            Util.WriteResult($"First bad version for n =  {n}: '{Solution1(n)}'");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static int Solution1(int n)
        {
            Util.WriteDebug("Using Binary search, run the loop until left < right");
            Util.WriteDebug("The right will keep storing the mid values until finding bad versions");
            Util.WriteDebug("When find the first bad version, the right should already be traversed all bad version(s), hence the left will be first bad version");

            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (left + right) / 2;

                Util.WriteDebug($"left = {left}, right = {right}, mid = {mid}");

                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        private static bool IsBadVersion(int n)
        {
            if (n > 3)
            {
                return true;
            }

            return false;
        }
    }
}
