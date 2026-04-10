/*namespace _1._Two_Sum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution {
            public int[] TwoSum(int[] nums, int target) {
                
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                            return new int[] { i, j };
                    }
                }
                return null;
            }
        }
    }
}*/


namespace _1._Two_Sum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                var indexedNums = new int[nums.Length][];
                for (int i = 0; i < nums.Length; i++)
                {
                    indexedNums[i] = new int[] { nums[i], i };
                }

                
                Array.Sort(indexedNums, (a, b) => a[0].CompareTo(b[0]));

                
                int left = 0;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int currentSum = indexedNums[left][0] + indexedNums[right][0];

                    if (currentSum == target)
                    {
                        
                        return new int[] { indexedNums[left][1], indexedNums[right][1] };
                    }
                    else if (currentSum > target)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }

                return Array.Empty<int>();
            }
        }
    }
}