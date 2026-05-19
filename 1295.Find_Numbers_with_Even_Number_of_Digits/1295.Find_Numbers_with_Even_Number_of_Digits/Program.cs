// 1295. Find Numbers with Even Number of Digits
// Given an array nums of integers, return how many of them contain an even number of digits.
// My Solution (not the best solution for runtime)
public class Solution
{
    public int FindNumbers(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int result = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            count = 0;
            while (nums[i] > 0)
            {
                nums[i] /= 10;
                count++;
            }
            if (count % 2 == 0) result++;
        }
        return result;
    }
}

// Best Solution for runtime 
int countOfEvenDigits = 0;
foreach (int num in nums)
{
    var number = num.ToString();
    int numberOfDigits = number.Length;
    if (numberOfDigits % 2 == 0)
    {
        countOfEvenDigits++;
    }
}
return countOfEvenDigits;