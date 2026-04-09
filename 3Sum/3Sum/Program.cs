// My Solution

/*public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right] + nums[i];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left-1]) left++;
                    while (left < right && nums[right] == nums[right+1]) right--;

                }

                if (sum < 0)
                    left++;
                if(sum>0)
                    right--;
            }
        }
        return result;
    }
}*/


// Best solution

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {

        nums.Sort();
        // we can not instantiate interface so we need to have a list. datatype can still be an interface to make it generic. Though the inside is not being instantiated yet, so keep it generic.
        // right side: a list of things that are IList<int> 
        IList<IList<int>> res = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] > 0) break;
            if ((i > 0 && nums[i] == nums[i - 1])) continue;
            int target = 0 - nums[i];
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] > target)
                {
                    right--;
                }
                else if (nums[left] + nums[right] < target)
                {
                    left++;
                }
                else
                {
                    res.Add(new int[] { nums[i], nums[left], nums[right] });
                    while (left + 1 < nums.Length && nums[left] == nums[left + 1])
                    {
                        left++;
                    }
                    while (right - 1 > -1 && nums[right] == nums[right - 1])
                    {
                        right--;
                    }
                    left++;
                    right--;
                }
            }
        }
        return res;
    }
}