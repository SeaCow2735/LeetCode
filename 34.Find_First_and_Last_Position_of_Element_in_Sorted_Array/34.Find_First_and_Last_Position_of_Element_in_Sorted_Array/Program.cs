// 34. Find First and Last Position of Element in Sorted Array
// Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.
// If target is not found in the array, return [-1, -1].
// You must write an algorithm with O(log n) runtime complexity.
// My Solution (not very effective running time solution)


/*public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] result = new int[2];
        result[0] = -1;
        result[1] = -1;
        if (nums.Length == 0)
        {
            return result;
        }

        for(int i = 0; i<nums.Length;i++)
        {
            if(nums[i] == target)
            {
                if(result[0] == -1)
                {
                    result[0] = i;
                }
                else
                {
                    result[1] = i;
                }
            }
        }
        if (result[0] != -1 && result[1] == -1)
        {
            result[1] = result[0];
        }
        return result;
    }
}*/


//Best solution for running time
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        //int[] result = new int();
        //int mid = left + (right - left) / 2;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) right = mid - 1;
            else if (nums[mid] < target) left = mid + 1;
            else
                right = mid - 1;

        }
        int left_f = 0;
        int right_f = nums.Length - 1;
        while (left_f <= right_f)
        {
            int mid = left_f + (right_f - left_f) / 2;
            if (nums[mid] == target) left_f = mid + 1;
            else if (nums[mid] < target) left_f = mid + 1;
            else
                right_f = mid - 1;
        }
        if (left >= nums.Length || nums[left] != target) return new int[] { -1, -1 };
        return new int[] { left, right_f };
    }
}