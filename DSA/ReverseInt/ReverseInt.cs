//Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

//Assume the environment does not allow you to store 64-bit integers (signed or unsigned).


//Example 1:
//Input: x = 123
//Output: 321

//Example 2:
//Input: x = -123
//Output: -321

//Example 3:
//Input: x = 120
//Output: 21

namespace ReverseInt
{
    internal static class ReverseInt
    {
        public static void ReverseNum(int num)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"Reversed Int for {num}: { Solution1(num)}");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static long Solution1(int num)
        {
            bool isNegative = false;

            if (num < 0)
            {
                isNegative = true;
                num *= -1;
            }

            long reversedInt = 0;

            while (num > 0)
            {
                Util.WriteDebug($"reversedInt: ({reversedInt} * 10) + ({num} % 10) = {(reversedInt * 10) + (num % 10)}");
                reversedInt = (reversedInt * 10) + (num % 10);
                int logNum = num;
                num /= 10;
                Util.WriteDebug($"num: {logNum}: {logNum} / 10 = {num}");
            }

            if (reversedInt > int.MaxValue)
            {
                return 0;
            }

            return isNegative ? reversedInt * -1 : reversedInt;
        }
    }
}
