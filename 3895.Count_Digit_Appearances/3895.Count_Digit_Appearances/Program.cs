//3895. Count Digit Appearances
// My Solution 
public class Solution
{
    public int CountDigitOccurrences(int[] nums, int digit)
    {
        int temp = 0;
        int count = 0;
        int dig = 0;
       for(int i = 0;i<nums.Length;i++)
        {
            temp = nums[i];
            while (temp != 0)
            {
                dig = temp % 10;
                temp = temp / 10;
                if (dig == digit)
                    count++;
            }
        }
        return count;
    }
}

// The best runtime solution 
/*public class Solution
{
    public int CountDigitOccurrences(int[] nums, int digit)
    {
        int count = 0;

        foreach (int num in nums)
        {
            for (int temp = num; temp > 0; temp /= 10)
            {
                count += temp % 10 == digit ? 1 : 0;
            }
        }

        return count;
    }
}*/