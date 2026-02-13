using System;

namespace NeetCode150.DP
{
    // Problem: Climbing Stairs
    // You are climbing a staircase. It takes n steps to reach the top.
    // Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
    
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2) return n;
            
            int prev = 1;  // f(1)
            int curr = 2;  // f(2)
            
            for (int i = 3; i <= n; i++)
            {
                int next = prev + curr;
                prev = curr;
                curr = next;
            }
            
            return curr;
        }
        
        public static void Main(string[] args)
        {
            ClimbingStairs solution = new ClimbingStairs();
            
            // Example 1
            int n1 = 2;
            Console.WriteLine($"Input: {n1}");
            Console.WriteLine($"Output: {solution.ClimbStairs(n1)}"); // Expected: 2
            
            // Example 2
            int n2 = 3;
            Console.WriteLine($"Input: {n2}");
            Console.WriteLine($"Output: {solution.ClimbStairs(n2)}"); // Expected: 3
            
            // Example 3
            int n3 = 5;
            Console.WriteLine($"Input: {n3}");
            Console.WriteLine($"Output: {solution.ClimbStairs(n3)}"); // Expected: 8
        }
    }
}