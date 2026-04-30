// 164. Maximum Gap
// My Solution - O(nlogn) time complexity and O(1) space complexity (ignoring the space used by sorting)
// Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
/*public class Solution
{
    public int MaximumGap(int[] nums)
    {
        if(nums.Length < 1) return 0;

        nums.Sort();
        int maxGap = 0;
        for(int i=1;i<nums.Length;i++)
        {
            int cur = nums[i] - nums[i - 1];
            if (cur > maxGap)
                maxGap = cur;
           
        }
        return maxGap;
    }
}*/


//Best Solution - O(n) time complexity and O(n) space complexity
// The idea is to use a bucket sort approach. We find the minimum and maximum values in the array, then create buckets to hold the numbers. Each bucket will hold numbers that fall within a certain range. We then find the maximum gap by comparing the minimum value of the current bucket with the maximum value of the previous bucket.
// This approach allows us to achieve linear time complexity while still finding the maximum gap efficiently.
public class Solution
{
    public int MaximumGap(int[] nums)
    {
        int n = nums.Length;

        if (n < 2)
            return 0;

        int min = nums[0];
        int max = nums[0];

        for (int i = 1; i < n; i++)
        {
            min = System.Math.Min(min, nums[i]);
            max = System.Math.Max(max, nums[i]);
        }

        if (min == max)
            return 0;

        int bucketSize = System.Math.Max(1, (int)System.Math.Ceiling((double)(max - min) / (n - 1)));
        int bucketCount = (max - min) / bucketSize + 1;

        int[] bucketMin = new int[bucketCount];
        int[] bucketMax = new int[bucketCount];
        bool[] used = new bool[bucketCount];

        for (int i = 0; i < bucketCount; i++)
        {
            bucketMin[i] = int.MaxValue;
            bucketMax[i] = int.MinValue;
        }

        foreach (int num in nums)
        {
            int index = (num - min) / bucketSize;

            bucketMin[index] = System.Math.Min(bucketMin[index], num);
            bucketMax[index] = System.Math.Max(bucketMax[index], num);
            used[index] = true;
        }

        int result = 0;
        int prevMax = min;

        for (int i = 0; i < bucketCount; i++)
        {
            if (!used[i])
                continue;

            result = System.Math.Max(result, bucketMin[i] - prevMax);
            prevMax = bucketMax[i];
        }

        return result;
    }
}