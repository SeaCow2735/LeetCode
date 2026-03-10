namespace SIngleNumber1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution {
            public int SingleNumber(int[] nums) {
                int result = 0;
                foreach (int num in nums) {
                    result ^= num; 
                }
                return result;
            }
        }

    }
}