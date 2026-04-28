
// 75. Sort Colors
// My Solution (Best Solution) 
// Time Complexity: O(n) 
// Space Complexity: O(1)
// Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
// We will use the Dutch National Flag algorithm, which is a three-pointer approach.
// We will maintain three pointers: low, current, and high.
// The low pointer will track the position of the last red (0) element,
// the current pointer will traverse the array, and the high pointer will track the position of the first blue (2) element.
// We will iterate through the array and swap elements based on their values to ensure that all 0s are moved to the beginning, all 1s are in the middle, and all 2s are moved to the end.
public class Solution
{
    public void SortColors(int[] nums)
    {
        if(nums.Length == 0) return;
        int low = 0, current = 0, high = nums.Length - 1;
        while (current <= high)
        {
            switch (nums[current])
            {
                case 0:
                    Swap(nums, low, current);
                    low++;
                    current++;
                    break;
                case 1:
                    current++;
                    break;
                case 2:
                    Swap(nums, current, high);
                    high--;
                    break;
                default:
                    current++;
                    break;
            }

        }
    }

    public void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

// Another Solution (Less Optimal Solution)
// Time Complexity: O(n)
// Space Complexity: O(1)
// In this solution, we will count the number of 0s, 1s, and 2s in the array and then overwrite the original array with the counted values.
// We will first iterate through the array to count the occurrences of each color (0s, 1s, and 2s).
// After counting, we will overwrite the original array based on the counts, filling in 0s first, then 1s, and finally 2s.
// This approach is less optimal than the Dutch National Flag algorithm because it requires two passes through the array (one for counting and one for overwriting), whereas the Dutch National Flag algorithm sorts the array in a single pass.
// Note: The above solution is not the most optimal solution, but it is a valid solution that meets the problem requirements.
/*public class Solution
{
    public void SortColors(int[] nums)
    {
        int count0 = 0 , count1 = 0, count2 = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0) count0++;
            else if(nums[i] == 1) count1++;
            else if(nums[i] == 2) count2++;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if(i < count0) nums[i] = 0;
            else if(i < count0 + count1) nums[i] = 1;
            else nums[i] = 2;
        }
    }
}*/