//Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

//You must write an algorithm with O(log n) runtime complexity.



//Example 1:

//Input: nums = [-1, 0, 3, 5, 9, 12], target = 9
//Output: 4
//Explanation: 9 exists in nums and its index is 4
//Example 2:

//Input: nums = [-1, 0, 3, 5, 9, 12], target = 2
//Output: -1
//Explanation: 2 does not exist in nums so return -1

namespace SimpleBinarySearch
{
    internal static class SimpleBinarySearch
    {
        public static void BinarySearch(int[] arr, int search)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"{search} is at index: '{Solution1(arr, search)}'");
            Util.WriteDebug("Function End");
            Util.Spacer();

        }

        private static int Solution1(int[] arr, int search)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                Util.WriteDebug($"left = {left}, right = {right}, mid = {mid}");

                if (arr[mid] > search)
                {
                    right = mid - 1;
                }
                else if (arr[mid] < search)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
