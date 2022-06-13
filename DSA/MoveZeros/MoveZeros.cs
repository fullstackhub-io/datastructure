//Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

//Note that you must do this in-place without making a copy of the array.

 

//Example 1:
//Input: nums = [0, 1, 0, 3, 12]
//Output:[1,3,12,0,0]

//Example 2:
//Input: nums = [0]
//Output:[0]

namespace MoveZeros
{
    internal static class MoveZeros
    {
        public static void MoveZerostoRight(int[] nums)
        {
            Util.WriteDebug("Function Start");
            Solution1(nums);
            Util.WriteResult($"After moving zeros to right : {string.Join(",", nums)}");
            Util.WriteDebug("Function End");
            Util.Spacer();
            
        }

        private static void Solution1(int[] nums)
        {
            Util.WriteDebug("Traverse the array and re-arrange it by inserting only non-zero number");
            Util.WriteDebug("Keep the last index of non-zero number and insert 0 at the end to array length");

            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            for(int i = index; i < nums.Length;i++)
            {
                nums[i] = 0;
            }

        }
    }
}
