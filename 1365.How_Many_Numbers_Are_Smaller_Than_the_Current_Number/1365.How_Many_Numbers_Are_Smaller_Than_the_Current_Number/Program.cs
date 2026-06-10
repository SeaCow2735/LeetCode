//1365. How Many Numbers Are Smaller Than the Current Number
//My solution (not the best runtime solution)
/*public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int count = 0;
        int[] result = new int [nums.Length];
        for(int i = 0;i<nums.Length;i++)
        {
            for(int j=0;j<nums.Length;j++)
            {
                if(nums [i] > nums [j])
                {
                    count++;
                }
            }
            result[i] = count;
            count = 0;
        }
        return result;
    }
}*/
// the best runtime solution
public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int max = 101;
        // foreach(var num in nums){
        //     min = Math.Min(num,min);
        //     max = Math.Max(num,max);
        // }

        int[] c = new int[max + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            c[nums[i]] += 1;
        }
        int smallerCount = 0;
        for (int i = 0; i < c.Length; i++)
        {
            var counter = c[i];
            c[i] = smallerCount;
            smallerCount += counter;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = c[nums[i]];
        }
        return nums;
    }
}