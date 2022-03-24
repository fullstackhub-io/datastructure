//Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.



//Example 1:

//Input: nums = [1, 2, 3, 1], k = 3
//Output: true
//Example 2:

//Input: nums = [1, 0, 1, 1], k = 1
//Output: true
//Example 3:

//Input: nums = [1, 2, 3, 1, 2, 3], k = 2
//Output: false


namespace ContainsDuplicateII
{
    internal static class ContainsDuplicate
    {
        public static void IfContainsDuplicate(int[] nums, int k)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"Does array {string.Join(",",nums)} contain duplicate in {k} range? {Solution1(nums, k)}");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static bool Solution1(int[] nums, int k)
        {
            Util.WriteDebug("Use the dictionary to get already visited numbers");
            Util.WriteDebug("Store number and its index in dictionary");
            Util.WriteDebug($"Check if already visited number index difference with current index is less than or equal to {k}");

            Dictionary<int, int> map = new();

            for (int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                if (map.ContainsKey(current) && (i - map[current]) <= k)
                {
                    return true;
                }
                else
                   if (!map.ContainsKey(current))
                {
                    map.Add(current, i);
                }
            }

            return false;
        }
    }
}
