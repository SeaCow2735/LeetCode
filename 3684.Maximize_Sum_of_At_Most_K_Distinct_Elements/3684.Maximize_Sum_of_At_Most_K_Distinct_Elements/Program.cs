//3684. Maximize Sum of At Most K Distinct Elements
// My Solution

public class Solution
{
    public int[] MaxKDistinct(int[] nums, int k)
    {
        HashSet<int> a = new HashSet<int>();
        Array.Sort(nums);
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (a.Count < k)
            {
                a.Add(nums[i]);
            }
            else
            {
                break;
            }
        }
        return a.ToArray();
    }
}

// The best runtime solution
public class Solution
{
    public int[] MaxKDistinct(int[] nums, int k)
    {
        Array.Sort(nums, (a, b) => b.CompareTo(a));

        var maxKDistinctNums = new List<int>();
        foreach (int num in nums)
        {
            if (
              maxKDistinctNums.Count > 0
              && maxKDistinctNums[^1] == num
            ) continue;

            maxKDistinctNums.Add(num);

            if (--k == 0) break;
        }

        return maxKDistinctNums.ToArray();
    }
}