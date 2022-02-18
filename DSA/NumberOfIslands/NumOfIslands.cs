//Given an m x n 2D binary grid which represents a map of '1's (land) and '0's(water), return the number of islands.

//An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

 

//Example 1:

//Input: grid = [
//  ["1","1","1","1","0"],
//  ["1","1","0","1","0"],
//  ["1","1","0","0","0"],
//  ["0","0","0","0","0"]
//]
//Output: 1
//Example 2:

//Input: grid = [
//  ["1","1","0","0","0"],
//  ["1","1","0","0","0"],
//  ["0","0","1","0","0"],
//  ["0","0","0","1","1"]
//]
//Output: 3

namespace NumberOfIslands
{
    internal static class NumOfIslands
    {
        public static void GetNumOfIslands(char[][] grid)
        {
            Util.WriteDebug("Function Start");
            Util.WriteResult($"The number of Island(s) in {grid}:  {Solution1(grid)}");
            Util.WriteDebug("Function End");
            Util.Spacer();
            
        }

        private static int Solution1(char[][] grid)
        {
            Util.WriteDebug("Edge case if grid is null or empty");
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int numofIslands = 0;

            Util.WriteDebug("If there is 1, it means it is an island, use DFS to find the adjacent islands");
            Util.WriteDebug("Traverse the entire grid if found 1 to find its neighbours");
            Util.WriteDebug("Make all adjacent 1 (islands) to 0 to count them as single island");

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        numofIslands += Dfs(grid, i, j);
                    }
                }
            }

            return numofIslands;
        }

        private static int Dfs(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
            {
                return 0;
            }

            grid[i][j] = '0';

            Dfs(grid, i + 1, j);
            Dfs(grid, i - 1, j);
            Dfs(grid, i, j + 1);
            Dfs(grid, i, j - 1);

            return 1;
        }
    }
}
