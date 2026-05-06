// 448. Find All Numbers Disappeared in an Array
// Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
// Find all the elements of [1, n] inclusive that do not appear in this array.
// Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
// My Solution (Best Solution for run time)
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;

            if (nums[index] > 0)
            {
                nums[index] = -nums[index];
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                result.Add(i + 1);
            }
        }

        return result;
    }
}