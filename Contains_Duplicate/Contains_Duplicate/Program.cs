namespace Contains_Duplicate
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class Solution
    {
        public bool ContainsDuplicate(int[] num)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < num.Length; i++)
            {
                if (set.Contains(num[i]))
                {
                    return true;
                }
                set.Add(num[i]);
            }
            return false;
        }

       
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[] { 1, 2, 3, 4 };
            bool result = solution.ContainsDuplicate(nums);
            Console.WriteLine(result);
        }
    }
}



public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // if(nums.Length <= 1)
        //     return false;
        // Dictionary<int, int> dict = new Dictionary<int, int>();

        // for(int a=0;a<nums.Length;a++){
        //     if(dict.ContainsKey(nums[a])){
        //         return true;
        //     }
        //     dict[nums[a]] = a;
        // }

        // return false;

        int n = nums.Length;
        for (int i = 1; i < n; i++)
        {
            for (int j = i; j > 0 && nums[j - 1] >= nums[j]; j--)
            {
                if (nums[j] == nums[j - 1])
                {
                    return true;
                }
                (nums[j], nums[j - 1]) = (nums[j - 1], nums[j]);
            }

        }
        return false;
    }
}