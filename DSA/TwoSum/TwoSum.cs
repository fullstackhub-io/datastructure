//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.



//Example 1:
//Input: nums = [2, 7, 11, 15], target = 9
//Output:[0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].

//Example 2:
//Input: nums = [3, 2, 4], target = 6
//Output:[1,2]

//Example 3:
//Input: nums = [3, 3], target = 6
//Output:[0,1]


//Constraints:

//2 <= nums.length <= 104
//- 109 <= nums[i] <= 109
//- 109 <= target <= 109
//Only one valid answer exists.

namespace TwoSum
{
    internal static class TwoSum
    {
        public static void GetTwoSum(int[] arr, int targt)
        {

            Util.WriteDebug("Function Start");

            var res = Solution1(arr, targt);

            string? output = res != null ? string.Join(",", res) : "not found!";

            Util.WriteResult($"Target Sum \"{targt}\" in \"{string.Join(",", arr)}\" exist at indexes: {output}");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static int[]? Solution1(int[] arr, int target)
        {
            Util.WriteDebug("Use HashSet (Dictionary in C#) to store the value as a key and index as a value");
            Util.WriteDebug("Traverse each element, if target number minus current item exist in hashset, return both indexes, else keep adding number in hashset");
            Dictionary<int, int> dict = new();

            for (int i = 0; i < arr.Length; i++)
            {
                int key = target - arr[i];

                if (dict.ContainsKey(key))
                {
                    return new int[] { dict[key], i };
                }
                else
                {
                    dict.Add(arr[i], i);
                }
            }

            return null;
        }
    }
}
