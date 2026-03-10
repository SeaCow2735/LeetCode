using System;
using System.Collections.Generic;

namespace Contains_Duplicate_II
{
    internal class Program
    {
        /*public class Solution {
            public bool ContainsNearbyDuplicate(int[] nums, int k) {
                for (int j = 0; j < nums.Length - 1; j++) {
                    for (int i = j + 1; i < nums.Length; i++) {
                        if (nums[i] == nums[j] && Math.Abs(i - j) <= k) {
                            return true;
                        }
                    }
                }
                return false;
            }
        }*/
        public class Solution
        {
            public bool ContainsNearbyDuplicate(int[] nums, int k) {
                Dictionary<int, int> map = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++) {
                    if (map.ContainsKey(nums[i]) && i - map[nums[i]] <= k) {
                        return true;
                    }
                    map[nums[i]] = i;
                }
                return false;
            } 
        }
        
        
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.ContainsNearbyDuplicate(new[] { 1,0,1}, 1)); 
            
        }
    }
}