//1470. Shuffle the Array
//My solution
public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] res = new int[nums.Length];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            res[index++] = nums[i];
            res[index++] = nums[n + i];
        }
        return res;
    }
}