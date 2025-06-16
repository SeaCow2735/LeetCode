using System;

namespace MaxProfit
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 7,1,5,3,6,4};
            Solution solution = new Solution();
            solution.MaxProfit(arr);
            Console.WriteLine(arr[1]);
        }
       public class Solution {
           public int MaxProfit(int[] prices) {
               int cur = 0;
               int max = 0;
               int j = 0;
       
               for (int i = 1; i < prices.Length; ++i) {
                   cur = prices[i] - prices[j];
                   if (cur < 0) {
                       cur = 0;
                       j = i;
                   }
                   if (cur > max) {
                       max = cur;
                   }
               }
               return max;
           }
       }
    }
}