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
