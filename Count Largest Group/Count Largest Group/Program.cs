using System;
using System.Linq;

namespace Count_Largest_Group
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            Solution solution = new Solution();
            int value=solution.CountLargestGroup(n);
            Console.WriteLine(value);
        }
        public class Solution
        {
            public int CountLargestGroup(int n)
            {
                var groupCounts = new int[4 * 9 + 1];
                for (var i = 1; i <= n; i++)
                {
                    groupCounts[DigitSum(i)] += 1;
                }
                var max = groupCounts.Max();
                return groupCounts.Count(gc => gc == max);
            }

            private int DigitSum(int x)
            {
                var sum = 0;
                while (x > 0)
                {
                    sum += x % 10;
                    x /= 10;
                }
                return sum;
            }
        }
    }
}