using System.Collections.Generic;

namespace Fibonacci_Number
{
    internal class Program
    {
        //My Solution
        /*public class Solution {
            public int Fib(int n) {
                if(n<=1)
                    return n;
                int f0=0;
                int f1=1;
                int temp =0;
                for(int i=2;i<=n;i++)
                {
                    temp=f0+f1;
                    f0=f1;
                    f1=temp;
                }
                return f1;
            }
        }*/
        
        //Best solution
        public class Solution {
            public int Fib(int n) {
                Dictionary<int, int> mem = new Dictionary<int, int>();
                return fibMem(n, mem);
            }

            private int fibMem(int n, Dictionary<int, int> mem)
            {
                if(n<= 1)
                {
                    return n;
                }

                if(mem.ContainsKey(n))
                {
                    return mem[n];
                }

                mem[n] = fibMem(n-1, mem) + fibMem(n-2, mem);

                return mem[n];
            }
        }
        public static void Main(string[] args)
        {
        }
    }
}