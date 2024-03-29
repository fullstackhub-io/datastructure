﻿//You are given two strings s and t.

//String t is generated by random shuffling string s and then add one more letter at a random position.

//Return the letter that was added to t.



//Example 1:

//Input: s = "abcd", t = "abcde"
//Output: "e"
//Explanation: 'e' is the letter that was added.
//Example 2:

//Input: s = "", t = "y"
//Output: "y"


namespace FindDifference
{
    internal static class FindDiff
    {
        public static void GetDiff(string s, string t)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"Extra characte in {t} is {Solution1(s, t)}");
            Util.WriteDebug("Function End");
            Util.Spacer();

        }

        private static char Solution1(string s, string t)
        {
            Util.WriteDebug("Save the first string characters in Hashmap with count");
            Util.WriteDebug("Check the second string characters in Hashmap");
            Util.WriteDebug("The count will help to check same character multiple times in second string");

            Dictionary<char, int> dict = new();

            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach (char c in t)
            {
                if (dict.ContainsKey(c) && dict[c] == 0 || !dict.ContainsKey(c))
                    return c;
                else
                {
                    dict[c]--;
                }
            }

            return Char.MinValue;

        }
    }
}
