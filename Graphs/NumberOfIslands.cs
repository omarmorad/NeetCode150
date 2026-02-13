using System;

namespace NeetCode150.Graphs
{
    // Problem: Number of Islands
    // Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water),
    // return the number of islands. An island is surrounded by water and is formed by connecting 
    // adjacent lands horizontally or vertically.
    
    public class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;
            
            int numIslands = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;
            
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        numIslands++;
                        Dfs(grid, r, c);
                    }
                }
            }
            
            return numIslands;
        }
        
        private void Dfs(char[][] grid, int r, int c)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            
            if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0')
            {
                return;
            }
            
            grid[r][c] = '0'; // Mark as visited
            
            // Explore neighbors
            Dfs(grid, r + 1, c); // Down
            Dfs(grid, r - 1, c); // Up
            Dfs(grid, r, c + 1); // Right
            Dfs(grid, r, c - 1); // Left
        }
        
        public static void Main(string[] args)
        {
            NumberOfIslands solution = new NumberOfIslands();
            
            // Example 1
            char[][] grid1 = new char[][]
            {
                new char[] {'1','1','1','1','0'},
                new char[] {'1','1','0','1','0'},
                new char[] {'1','1','0','0','0'},
                new char[] {'0','0','0','0','0'}
            };
            Console.WriteLine($"Number of islands: {solution.NumIslands(grid1)}"); // Expected: 1
            
            // Example 2
            char[][] grid2 = new char[][]
            {
                new char[] {'1','1','0','0','0'},
                new char[] {'1','1','0','0','0'},
                new char[] {'0','0','1','0','0'},
                new char[] {'0','0','0','1','1'}
            };
            Console.WriteLine($"Number of islands: {solution.NumIslands(grid2)}"); // Expected: 3
        }
    }
}