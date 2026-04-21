//My Solution to the Jump Game problem on LeetCode. The idea is to keep track of the maximum reachable index at each step. If at any point the current index exceeds the maximum reachable index, it means we cannot reach that point and we return false. If we can iterate through the entire array without exceeding the maximum reachable index, we return true.
//Best Solution: The provided solution is efficient with a time complexity of O(n) and a space complexity of O(1). It iterates through the array once, updating the maximum reachable index based on the current index and the jump length at that index. If at any point the current index exceeds the maximum reachable index, it returns false, indicating that we cannot reach that point. If we successfully iterate through the entire array, it returns true, indicating that we can reach the end of the array.
public class Solution
{
    public bool CanJump(int[] nums)
    {
        int maxReach = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (maxReach < i)
            {
                return false;
            }
            maxReach = Math.Max(maxReach, i + nums[i]);
        }
        return true;
    }
}