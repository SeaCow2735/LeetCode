//My solution
/*public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int nonzero = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[i];
                nums[i] = nums[nonzero];
                nums[nonzero] = temp;
                nonzero++;
            }
        }
    }
}*/

//Best solution
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int j = 0; int i = 0;
        while (i < nums.Length)
        {
            if (nums[i] != 0)
            {
                int tmp = nums[j];
                nums[j] = nums[i];
                nums[i] = tmp;
                j++;
                i++;
            }
            else i++;
        }
    }
}