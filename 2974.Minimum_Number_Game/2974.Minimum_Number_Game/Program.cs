//2974. Minimum Number Game
// My solution (the best solution for runtime)
public class Solution
{
    public int[] NumberGame(int[] nums)
    {
        int temp = 0;
        nums.Sort();
        for (int i = 0; i <= nums.Length-1;i=i+2)
        {
           temp = nums[i];
           nums[i] = nums[i+1];
            nums[i + 1] = temp;
            temp = 0;
        }
        return nums;
    }
}