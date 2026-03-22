namespace Arranging_Coins
{
    internal class Program
    {
        //My solution 
        /*public class Solution {
            public int ArrangeCoins(int n) {
                if(n==0)
                    return 0;
                if(n<=2)
                    return 1;
                int length=n;
                int count=1;
                n=n-1;
                for(int i=2;i<=length/2+1;i++)
                {
                    if(i>n)
                        break;
                    n=n-i;
                    count++;
                }
                return count;
            }
        }*/
        
        //Best solution
        /*public class Solution {
            public int ArrangeCoins(int n) {
                // n = x * (x + 1) / 2
                // 0 = x^2 + x - 2n
                // x = -1/2 + sqrt(8n + 1)/2
                return (int)(-0.5 + Math.Sqrt(8L * n + 1)/2);
            }
        }*/
        public static void Main(string[] args)
        {
        }
    }
}