// 343. Integer Break
//My Solution (Best Solution for running time) 
//Given an integer n, break it into the sum of k positive integers, where k >= 2, and maximize the product of those integers. Return the maximum product you can get.
public class Solution
{
    public int IntegerBreak(int n)
    {
        if(n==2) return 1;
        int count= 0;
        int result = 0;
        while(n > 4)
        {
            count++;
            n-=3;
        }
        if(count == 0 && n<=3) return n-1;
        if(n==1) return (int)Math.Pow(3, count-1)*4;
        else if(n==2) return (int)Math.Pow(3, count)*2;
        else return (int)Math.Pow(3, count)*n;
    }
}
// Other Solutions (Best for memory)
/*public class Solution
{
    public int IntegerBreak(int n)
    {
        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 1;

        for (int i = 3; i <= n; i++)
        {
            for (int j = 1; j < i; j++)
            {
                int product = j * (i - j);
                dp[i] = Math.Max(dp[i], Math.Max(product, j * dp[i - j]));
            }
        }
        return dp[n];
    }

}
*/