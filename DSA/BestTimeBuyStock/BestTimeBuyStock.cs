using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BestTimeBuyStock
{
    internal static class BestTimeBuyStock
    {
        public static void GetBestTimetoBuyStock(int[] stockPricePerDay)
        {
            Util.WriteDebug("Function Start");
            Util.WriteDebug("Problem is attached as JPG");
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
