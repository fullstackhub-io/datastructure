namespace StringAnagram
{
    internal static class Anagram
    {
        public static void IsStringAnagram(string str1, string str2)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"Is '{str1}' and '{str2}' Anagram? {Solution1(str1.ToLower(), str2.ToLower())}");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static bool Solution1(string str1, string str2)
        {
            const int ENGLISH_ALPHABETS = 26; 

            Util.WriteDebug($"First Input String: {str1}");
            Util.WriteDebug($"Second Input String: {str2}");

            if (str1.Length != str2.Length)
            {
                Util.WriteDebug("If both string lengths are not equal, they cannot be anagram!");
                return false;
            }

            Util.WriteDebug("Both string cannot have more than 26 alphabets.");
            int[] count = new int[ENGLISH_ALPHABETS];

            Util.WriteDebug("Str1[i] as a index will return ASCII value of character e.g. c = 99");
            Util.WriteDebug("After subtracting c - a (97), the index will be 2, so index always stay between 0 - 26");
            Util.WriteDebug("Since index is determined by character, for str1 increment must be decerment by str2 if both strings have same alphabets in different order.");

            for (int i=0; i< str1.Length; i++)
            {
                count[str1[i] - 'a']++;
                count[str2[i] - 'a']--;
            }

            Util.WriteDebug("If both string have same alphabets, the count shouldn't have any value greater than zero.");
            for (int i=0; i< count.Length; i++)
            {
                if (count[i] > 0)
                    return false;
            }

           return true; 

        }
    }
}
