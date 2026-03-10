using System;

namespace Nim_Game
{
    internal class Program
    {
        public class Solution {
            public bool CanWinNim(int n)
            {
                if (n <= 3)
                    return true;
                int count = 1;
                while (n >=4)
                {
                    if (n - 3 > 1)
                    {
                        n = n - 1;
                        count++;
                    }
                    n = n - 3;
                    count++;
                }
                
                
                if (n<=3 && count % 2 != 0 )
                {
                    return true;
                }
                return false;
            }
        }
        //best solution (0ms)
        /*public class Solution {
            public bool CanWinNim(int n) {
                return n % 4 != 0;
            }
        }*/
        
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.CanWinNim(5));
        }
    }
}