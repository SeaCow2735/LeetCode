//My solution to the Jump Game II problem on LeetCode. The idea is to keep track of the maximum reachable index at each step and count the number of jumps needed to reach the end of the array. We iterate through the array and update the farthest reachable index based on the current index and the jump length at that index. Whenever we reach the end of the current jump, we increment the jump count and update the current end to the farthest reachable index. Finally, we return the total number of jumps needed to reach the end of the array.
//Best Solution: The provided solution is efficient with a time complexity of O(n) and a space complexity of O(1). It iterates through the array once, updating the farthest reachable index based on the current index and the jump length at that index. Whenever we reach the end of the current jump, we increment the jump count and update the current end to the farthest reachable index. This approach ensures that we are always making the optimal jump at each step, leading to the minimum number of jumps needed to reach the end of the array.
public class Solution
{
    public int Jump(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 0;
        }

        int jumps = 0;
        int currentEnd = 0;
        int farthest = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]);

            if (i == currentEnd)
            {
                jumps++;
                currentEnd = farthest;
            }
        }
        return jumps;
    }
}