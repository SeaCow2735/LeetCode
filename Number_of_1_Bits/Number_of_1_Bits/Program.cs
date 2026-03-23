using System;

namespace Number_of_1_Bits
{
    internal class Program
    {
        //My solution (0ms)
        public class Solution {
            public int HammingWeight(int n) {
                string binaryString = Convert.ToString(n, 2);
                int sum=0;
                for(int i=0;i<binaryString.Length;i++){
                    if(binaryString[i]=='1')
                        sum++;
                }
                return sum;
            }
        }
        //Best Solution for memory
        /*public class Solution {
            public int HammingWeight(int n) {
                int res = 0;
                while (n >= 1) {
                    res = n % 2 == 1 ? res + 1: res;
                    n /= 2;
                }

                return res;
        
            }
        }*/
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.HammingWeight(11));
        }
    }
}