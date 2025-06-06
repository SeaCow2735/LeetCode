using System;
using System.Globalization;
using System.Linq;

namespace remove_duplicates_from_sorted_array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution {
            public int RemoveDuplicates(int[] nums) {
                if (nums == null || nums.Length == 0)
                    return 0;

                int k = 1; 

                for (int i = 1; i < nums.Length; i++) {
                    if (nums[i] != nums[k - 1]) {
                        nums[k] = nums[i]; 
                        k++;
                    }
                }

                return k;
            }
        }

    }
}