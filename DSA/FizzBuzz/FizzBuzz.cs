//Given an integer n, return a string array answer (1-indexed) where:

//answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
//answer[i] == "Fizz" if i is divisible by 3.
//answer[i] == "Buzz" if i is divisible by 5.
//answer[i] == i(as a string) if none of the above conditions are true.
 

//Example 1:

//Input: n = 3
//Output:["1","2","Fizz"]
//Example 2:

//Input: n = 5
//Output:["1","2","Fizz","4","Buzz"]
//Example 3:

//Input: n = 15
//Output:["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]

namespace FizzBuzz
{
    internal static class FizzBuzz
    {
        public static void ExecFizzBuzz(int n)
        {
            Util.WriteDebug("Function Start");
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
