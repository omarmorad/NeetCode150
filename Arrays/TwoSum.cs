using System;
using System.Collections.Generic;

namespace NeetCode150.Arrays
{
    // Problem: Two Sum
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    
    public class TwoSum
    {
        public int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }
            
            return new int[] { }; // Should not reach here given problem constraints
        }
        
        public static void Main(string[] args)
        {
            TwoSum solution = new TwoSum();
            
            // Example 1
            int[] nums1 = {2, 7, 11, 15};
            int target1 = 9;
            int[] result1 = solution.FindTwoSum(nums1, target1);
            Console.WriteLine($"Input: nums = [{string.Join(", ", nums1)}], target = {target1}");
            Console.WriteLine($"Output: [{string.Join(", ", result1)}]"); // Expected: [0, 1]
            
            // Example 2
            int[] nums2 = {3, 2, 4};
            int target2 = 6;
            int[] result2 = solution.FindTwoSum(nums2, target2);
            Console.WriteLine($"Input: nums = [{string.Join(", ", nums2)}], target = {target2}");
            Console.WriteLine($"Output: [{string.Join(", ", result2)}]"); // Expected: [1, 2]
            
            // Example 3
            int[] nums3 = {3, 3};
            int target3 = 6;
            int[] result3 = solution.FindTwoSum(nums3, target3);
            Console.WriteLine($"Input: nums = [{string.Join(", ", nums3)}], target = {target3}");
            Console.WriteLine($"Output: [{string.Join(", ", result3)}]"); // Expected: [0, 1]
        }
    }
}