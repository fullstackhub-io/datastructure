//Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

//You must implement a solution with a linear runtime complexity and use only constant extra space.



//Example 1:

//Input: nums = [2, 2, 1]
//Output: 1
//Example 2:

//Input: nums = [4, 1, 2, 1, 2]
//Output: 4

namespace FirstNonRepeatingSingleNum
{
    internal static class FirstNonRepeatNum
    {
        public static void GetFirstNonRepeatNum(int[] arr)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"The first unique character in '{string.Join(",",arr)}' is {Solution1(arr)}");
            Util.WriteDebug("Function End");
            Util.Spacer();

            Solution1(arr);
        }

        private static int Solution1(int[] arr)
        {
            Util.WriteDebug("Use hashset(dictionary) to store the array item as key and count as value");
            Dictionary<int, int> dict = new();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            Util.WriteDebug("used LINQ to find first item in array where its count = 1");
            return dict.FirstOrDefault(x => x.Value == 1).Key;
        }
    }
}
