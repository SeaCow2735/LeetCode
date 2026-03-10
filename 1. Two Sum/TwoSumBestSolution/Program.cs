using System.Collections.Generic;
namespace TwoSumBestSolution
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution {
            public int[] TwoSum(int[] nums, int target) {
                Dictionary<int, int> map = new Dictionary<int, int>();
                map[nums[0]] = 0;

                for (int i = 1; i < nums.Length; i++) {
                    int current = nums[i];
                    int x = target - current;
                    if (map.ContainsKey(x)) {
                        return new int[2] { map[x], i };
                    }
                    map[nums[i]] = i;
                }

                return new int[0];
            }
        }
    }
}