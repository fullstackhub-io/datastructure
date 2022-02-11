//Print integers 1 to N, but print “Fizz” if an integer is divisible by 3, “Buzz” if an integer is divisible by 5, and “FizzBuzz” if an integer is divisible by both 3 and 5.

namespace FizzBuzz
{
    internal static class FizzBuzz
    {
        public static void ExecFizzBuzz(int n)
        {
            Util.WriteDebug("Function Start");
            Util.WriteDebug("Problem is attached as JPG");
            Util.WriteResult($"Result {string.Join(",", Solution1(n))}");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static string[] Solution1(int n)
        {
            Util.WriteDebug("Use modulus % operator to check if number is multiple of 3 or 5 ");
            string[] result = new string[n];

            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                else
                {
                    result[i] = i.ToString();
                }
            }

            return result;
        }
    }
}
