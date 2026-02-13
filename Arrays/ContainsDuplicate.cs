using System;
using System.Collections.Generic;

// Problem: Contains Duplicate
// Given an integer array nums, return true if any value appears at least twice in the array, 
// and return false if every element is distinct.

bool HasDuplicate(int[] nums)
{
   HashSet<int> seen = new HashSet<int>();
   foreach(int num in nums)
    {
        if(!seen.Add(num))
        {
            return true;
        }
    
    }
    return false;
}
bool HasDuplicateWithSort(int[] nums)
{
    Array.Sort(nums);
    for(int i = 0 ; i < nums.Length - 1; i++)
    {
        if(nums[i] == nums[i + 1])
        {
            return true;
        }
    }
    return false;
}


int[] nums1 = {1, 2, 3, 1};
Console.WriteLine($"Input: [{string.Join(", ", nums1)}]");
Console.WriteLine($"Output: {HasDuplicate(nums1)}"); 


int[] nums2 = {1, 2, 3, 4};
Console.WriteLine($"Input: [{string.Join(", ", nums2)}]");
Console.WriteLine($"Output: {HasDuplicate(nums2)}"); 


int[] nums3 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
Console.WriteLine($"Input: [{string.Join(", ", nums3)}]");
Console.WriteLine($"Output: {HasDuplicateWithSort(nums3)}"); 
