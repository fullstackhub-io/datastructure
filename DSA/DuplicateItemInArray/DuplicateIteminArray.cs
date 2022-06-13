//442.Find All Duplicates in an Array
//Medium

//5728

//240

//Add to List

//Share
//Given an integer array nums of length n where all the integers of nums are in the range [1, n] and each integer appears once or twice, return an array of all the integers that appears twice.

//You must write an algorithm that runs in O(n) time and uses only constant extra space.

 

//Example 1:
//Input: nums = [4, 3, 2, 7, 8, 2, 3, 1]
//Output:[2,3]

//Example 2:
//Input: nums = [1, 1, 2]
//Output:[1]

//Example 3:
//Input: nums = [1]
//Output:[]

namespace DuplicateItemInArray
{
    internal static class DuplicateIteminArray
    {
        public static void IsArrayhasDuplicateItem(int[] arr)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"Does \"{string.Join(",", arr)}\" contains duplicate item:{Solution1(arr)}");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static bool Solution1(int[] arr)
        {
            Util.WriteDebug("Store each item in array in hashset (dictionary) key and '1' as value (value can be anything here)");
            Util.WriteDebug("Check if upcoming number already exist as a key in dictionary, return true");
            Dictionary<int, int> dict = new();
            
            for (int i = 0; i< arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    return true;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            return false;
        }
    }
}
