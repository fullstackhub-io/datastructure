//A peak element is an element that is strictly greater than its neighbors.

//Given an integer array nums, find a peak element, and return its index. If the array contains multiple peaks, return the index to any of the peaks.

//You may imagine that nums[-1] = nums[n] = -∞.

//You must write an algorithm that runs in O(log n) time.



//Example 1:

//Input: nums = [1, 2, 3, 1]
//Output: 2
//Explanation: 3 is a peak element and your function should return the index number 2.
//Example 2:

//Input: nums = [1, 2, 1, 3, 5, 6, 4]
//Output: 5
//Explanation: Your function can return either index number 1 where the peak element is 2, or index number 5 where the peak element is 6.


//Constraints:

//1 <= nums.length <= 1000
//- 231 <= nums[i] <= 231 - 1
//nums[i] != nums[i + 1] for all valid i.

namespace FindPeakElement
{
    internal static class PeakElement
    {
        public static void FindPeakElement(int[] arr)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"The peak element index in \"{string.Join(",", arr)}\":  {Solution1(arr)}");
            Util.WriteDebug("Function End");
            Util.Spacer();

        }

        private static int Solution1(int[] arr)
        {
            Util.WriteDebug("Use binary search");
            Util.WriteDebug("If number at mid index is less than it next neighbour, keep finding it on right side");
            Util.WriteDebug("If number at mid index is greater than it next neighbour, keep finding it on left side because there may be number(s) on left those are peak number(s)");

            int left = 0;
            int right = arr.Length - 1;

            Util.WriteDebug("Indexes debug start");
            while (left < right)
            {
                int mid = left + (right - left) / 2;

                Util.WriteDebug($"Left = {left} | Right = {right} | Mid {left}+({right}-{left})/2 = {mid}");

                if (arr[mid] < arr[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            Util.WriteDebug("Indexes debug end");

            return left;
        }
    }
}
