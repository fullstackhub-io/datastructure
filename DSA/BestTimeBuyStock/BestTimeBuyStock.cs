//You are given an array prices where prices[i] is the price of a given stock on the ith day.

//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

//Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 

//Example 1:

//Input: prices = [7, 1, 5, 3, 6, 4]
//Output: 5
//Explanation: Buy on day 2(price = 1) and sell on day 5 (price = 6), profit = 6 - 1 = 5.
//Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
//Example 2:

//Input: prices = [7, 6, 4, 3, 1]
//Output: 0
//Explanation: In this case, no transactions are done and the max profit = 0.
 

//Constraints:

//1 <= prices.length <= 105
//0 <= prices[i] <= 104


namespace BestTimeBuyStock
{
    internal static class BestTimeBuyStock
    {
        public static void GetBestTimetoBuyStock(int[] stockPricePerDay)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"Max profit can be earned = {Solution1(stockPricePerDay)}");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static int Solution1(int[] stockPricePerDay)
        {
            Util.WriteDebug("Assign stock price to Max value to get min stock price");
            int minPrice = int.MaxValue;
            int profit = 0;

            Util.WriteDebug("Traverse the stock price per day array");
            Util.WriteDebug("First, get the minimum stock price");
            Util.WriteDebug("Second, See the current price difference with minimum price");
            Util.WriteDebug("Third, if price difference is greater than previous price difference, it is more porfit");
            for (int i = 0; i < stockPricePerDay.Length; i++)
            {
                if (stockPricePerDay[i] < minPrice)
                {
                    minPrice = stockPricePerDay[i]; 
                }

                int priceDiff = stockPricePerDay[i] - minPrice;

                if (stockPricePerDay[i] > minPrice && priceDiff > profit)
                {
                    profit = priceDiff;
                }
            }

            return profit;
        }
    }
}
