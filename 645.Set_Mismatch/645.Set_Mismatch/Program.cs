// 645. Set Mismatch
// You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, which results in repetition of one number and loss of another number.
// You are given an integer array nums representing the data status of this set after the error. Find the number that occurs twice and the number that is missing and return them in the form of an array.
// My Solution (not the best solution for run time)
public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int[] result = new int[2];
        for (int i = 1; i <= nums.Length; i++)
        {
            if (!nums.Contains(i))
            {
                result[1] = i;
            }
            if(nums.Count(x => x == i) > 1)
            {
                result[0] = i;
            }
        }
        return result;
    }
}

// Better solution for run time
/*public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int n = nums.Length;

        long sum = 0, sumSq = 0;

        foreach (int num in nums)
        {
            sum += num;
            sumSq += (long)num * num;
        }

        long expectedSum = (long)n * (n + 1) / 2;
        long expectedSq = (long)n * (n + 1) * (2 * n + 1) / 6;

        long diff = expectedSum - sum; // missing - duplicate
        long diffSq = expectedSq - sumSq; // missing^2 - duplicate^2

        long sumMD = diffSq / diff; // missing + duplicate

        int missing = (int)((diff + sumMD) / 2);
        int duplicate = (int)(sumMD - missing);

        return new int[] { duplicate, missing };


    }
}*/