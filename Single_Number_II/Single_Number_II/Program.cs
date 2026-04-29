// Given an integer array nums where every element appears three times except for one, which appears exactly once. Find the single element and return it.
// You must implement a solution with a linear runtime complexity and use only constant extra space.
// 137. Single Number II
// https://leetcode.com/problems/single-number-ii/description/
// My Solution: Sort the array and check every 3 elements, if they are not the same, return the first one. If all 3 elements are the same, skip them and check the next 3 elements. If we reach the end of the array, return the last element.
// Time complexity: O(n log n) because of the sorting step. Space complexity: O(1) because we are not using any extra space.
// Note: This solution does not meet the requirement of linear runtime complexity, but it is a valid solution that works correctly.
/*public class Solution
{
    public int SingleNumber(int[] nums)
    {
        nums.Sort();
        for (int i = 0; i<= nums.Length - 3; i+=3)
        {
            if (nums[i] != nums[i + 1])
                return nums[i];
        }
        return nums[nums.Length -1];
    }
}*/

// Best Solution
// The idea is to use two variables, res and res1, to keep track of the bits that have been seen once and twice respectively. For each number in the array, we update res and res1 as follows:
// - res is updated by XORing it with the current number and ANDing it with the negation of res1. This ensures that if a bit has been seen twice, it will not be included in res.
// - res1 is updated by XORing it with the current number and ANDing it with the negation of res. This ensures that if a bit has been seen once, it will not be included in res1.
// After processing all numbers, res will contain the bits of the single number that appears once, and res1 will be 0. The time complexity of this solution is O(n) and the space complexity is O(1).
// Time complexity: O(n) because we are iterating through the array once. Space complexity: O(1) because we are using only a constant amount of extra space.
// Note: This solution is more efficient than the sorting solution and meets the requirement of linear runtime complexity and constant extra space.
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int res = 0;
        int res1 = 0;
        foreach (int num in nums)
        {
            res = (res ^ num) & ~res1;
            res1 = (res1 ^ num) & ~res;
        }

        return res;
    }
}