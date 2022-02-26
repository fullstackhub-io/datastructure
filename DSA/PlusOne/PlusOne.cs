//You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

//Increment the large integer by one and return the resulting array of digits.

//Example 1:

//Input: digits = [1, 2, 3]
//Output:[1,2,4]
//Explanation: The array represents the integer 123.
//Incrementing by one gives 123 + 1 = 124.
//Thus, the result should be [1,2,4].
//Example 2:

//Input: digits = [4, 3, 2, 1]
//Output:[4,3,2,2]
//Explanation: The array represents the integer 4321.
//Incrementing by one gives 4321 + 1 = 4322.
//Thus, the result should be [4,3,2,2].
//Example 3:

//Input: digits = [9]
//Output:[1,0]
//Explanation: The array represents the integer 9.
//Incrementing by one gives 9 + 1 = 10.
//Thus, the result should be [1,0].

namespace PlusOne
{
    internal static class PlusOne
    {
        public static void GetPlusOne(int[] digits)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"After Plus one {string.Join(",", digits)}: '{ string.Join(",", Solution1(digits)) }'");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static int[] Solution1(int[] digits)
        {
            Util.WriteDebug("Traverse the array, if last number is less than 9, simply increment it by 1");
            Util.WriteDebug("If last number is greater than 9, set 0 as last number and increment second to last number increment by 1 and so on");

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            Util.WriteDebug("For single number array e.g. [9], extend the array and simply put 1 in first index");

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}