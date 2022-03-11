//There are a row of n houses, each house can be painted with one of the three colors: red, blue or green. The cost of painting each house with a certain color is different. You have to paint all the houses such that no two adjacent houses have the same color.

//The cost of painting each house with a certain color is represented by a n x 3 cost matrix. For example, costs[0][0] is the cost of painting house 0 with color red; costs[1][2] is the cost of painting house 1 with color green, and so on… Find the minimum cost to paint all houses.

//For Example:
//If the given array is — {17, 2, 1}, { 16, 16, 1}, { 14, 3, 19}, { 3, 1, 8}
//then minimum cost of painting is 2 + 1 + 3 + 3 = 9

namespace PaintHouse
{
    internal static class PaintHouse
    {
        public static void GetPaintHouseCost(int[][] cost)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"The total cost is = '{Solution1(cost)}'");
            Util.WriteDebug("Function End");
            Util.Spacer();
        }

        private static int Solution1(int[][] cost)
        {
            if (cost == null || cost.Length == 0)
                return 0;

            for (int i = 1; i < cost.Length; i++)
            {
                Util.WriteDebug($"Before: cost[{i}][0] = {cost[i][0]}");
                cost[i][0] += Math.Min(cost[i - 1][1], cost[i - 1][2]);
                Util.WriteDebug($"After: cost[{i}][0] = {cost[i][0]}");

                Util.WriteDebug($"Before: cost[{i}][1] = {cost[i][1]}");
                cost[i][1] += Math.Min(cost[i - 1][0], cost[i - 1][2]);
                Util.WriteDebug($"After: cost[{i}][1] = {cost[i][1]}");

                Util.WriteDebug($"Before: cost[{i}][2] = {cost[i][2]}");
                cost[i][2] += Math.Min(cost[i - 1][2], cost[i - 1][1]);
                Util.WriteDebug($"After: cost[{i}][2] = {cost[i][2]}");
            }

            return Math.Min(Math.Min(cost[cost.Length-1][0], cost[cost.Length - 1][1]), cost[cost.Length-1][2]);
        }
    }
}
