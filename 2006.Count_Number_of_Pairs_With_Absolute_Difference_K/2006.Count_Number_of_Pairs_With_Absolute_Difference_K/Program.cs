//2006. Count Number of Pairs With Absolute Difference K
//My Solution 
public class Solution
{
    public int CountKDifference(int[] nums, int k)
    {
        nums.Sort();
        int count = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i+1; j < nums.Length; j++)
            {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        count++;
                    }
            }
        }
        return count;
    }
}
//Best runtime solution
/*public class Solution
{
    public int CountKDifference(int[] nums, int k)
    {
        int c = 0;
        int[] fre = new int[101];
        foreach (int num in nums)
        {
            if (num - k >= 0)
            {
                c += fre[num - k];
            }
            if (num + k <= 100)
            {
                c += fre[num + k];
            }
            fre[num]++;
        }
        return c;

    }
}*/