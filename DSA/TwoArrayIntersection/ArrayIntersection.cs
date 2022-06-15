//Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.



//Example 1:
//Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
//Output: [2]

//Example 2:
//Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
//Output: [9,4]
//Explanation: [4,9] is also accepted.

namespace TwoArrayIntersection
{
    internal class ArrayIntersection
    {
        public void Intersection(int[] nums1, int[] nums2)
        {
            var result = Solution1(nums1, nums2);
            Util.WriteResult($"The intersection of [{string.Join(",", nums1)}] & [{string.Join(",", nums2)}] is [{string.Join(",",result)}]");
        }

        private int[] Solution1(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> hashTable = new();
            List<int> result = new();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!hashTable.ContainsKey(nums1[i]))
                {
                    hashTable.Add(nums1[i], 1);
                }
            }


            foreach(var num in nums2)
            {
                if (hashTable.ContainsKey(num))
                {
                    result.Add(num);
                }
            }

            return result.Distinct().ToArray();
        }
    }
}
