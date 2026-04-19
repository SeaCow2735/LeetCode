//My Solution
/*public class Solution
{
    public int MaxSubArray(int[] nums)
    {
       if(nums.Length == 1)
            return nums[0];
       int cursum = 0;
        int maxsum = 0;
        for(int i =0;i<nums.Length;i++)
        {
            cursum += nums[i];
            if (cursum < 0)
                cursum = 0;
            if (cursum > maxsum)
            {
                maxsum = cursum;
            }

        }
        if(maxsum ==0)
        {
            maxsum=nums.Max();
        }
        return maxsum;
    }

}*/

//Best Solution
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int max = nums[0];
        int maxRunning = max;
        for (int i = 1; i < nums.Length; i++)
        {
            maxRunning = int.Max(maxRunning + nums[i], nums[i]);
            max = int.Max(max, maxRunning);
        }

        return max;
    }
}