using System.Linq.Expressions;

namespace SearchInsertPosition
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution {
            public int SearchInsert(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {
                        return i;
                        break;
                    }

                    if (nums[i] > target)
                    {
                        return i;
                        
                        break;
                    }
                }
                return nums.Length;
            }
        }
    }
}