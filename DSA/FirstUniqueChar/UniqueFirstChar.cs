 namespace FirstUniqueChar
{
    internal static class UniqueFirstChar
    {
        public static void GetFirstUniqueChar(string str)
        {
            Util.WriteDebug("Function Start");
            const string NOT_FOUND = "NOT FOUND";
            var resultIndex = Solution1(str);
            Util.WriteResult($"The first unique character in '{str}' is '{ (resultIndex > 0 ? str[resultIndex]: NOT_FOUND) }'");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static int Solution1(string str)
        {
            Util.WriteDebug($"Input String is '{str}'");

            Dictionary<char, int> charCount = new();

            Util.WriteDebug($"Storing the Characters in Input String as Key in Dictionary");
            Util.WriteDebug($"Storing the Characters Count as Value in Dictionary");
            Util.WriteDebug($"If Character appears again in String, setting the count as -1");

            for (int i = 0; i < str.Length; i++)
            {
                if (charCount.ContainsKey(str[i]))
                    charCount[str[i]] = -1;
                else
                    charCount.Add(str[i], 1);
            }


            Util.WriteDebug($"Checking the first Character in Dictionary that has count as 1 and returning the index");
            int index = 0;
            foreach (char c in charCount.Keys)
            {
                if (charCount[c] == 1)
                    return index;
                index++;
            }

            return -1;
        }
    }
}
