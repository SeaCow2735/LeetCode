namespace Missing_Number
{
    internal class Program
    {
        public class Solution {
            public int MissingNumber(int[] nums) {
                int n = nums.Length;
                int expected = n * (n + 1) / 2;

                int sum = 0;
                foreach (int num in nums)
                    sum += num;

                return expected - sum;
            }
        }
        public static void Main(string[] args)
        {
                
        }
    }
}