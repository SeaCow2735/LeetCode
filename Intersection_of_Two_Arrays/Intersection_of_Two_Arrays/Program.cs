using System.Collections.Generic;
using System.Linq;

namespace Intersection_of_Two_Arrays
{
    internal class Program
    {
        public class Solution {
            public int[] Intersection(int[] nums1, int[] nums2) {
                var hash1 = new HashSet<int>(nums1.ToList());
                var hash2 = new HashSet<int>(nums2.ToList());
                hash1.IntersectWith(hash2);
                var result = new int[hash1.Count];
                hash1.CopyTo(result);
                return result;

            }
        }
        public static void Main(string[] args)
        {
        }
    }
}