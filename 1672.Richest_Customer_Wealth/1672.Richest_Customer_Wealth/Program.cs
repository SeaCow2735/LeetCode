// 1672. Richest Customer Wealth
// My solution (not the best runtime solution)
public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int sum = 0;
        int rich = 0;
        foreach (var account in accounts)
        {
            foreach (var wealth in account)
            {
                sum += wealth;
            }
            rich = Math.Max(sum, rich);
            sum = 0;
        }
        return rich;
    }
}

// Best runtime solution 
/*public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int maxSum = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            int localSum = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                localSum += accounts[i][j];
            }
            maxSum = (localSum > maxSum) ? localSum : maxSum;
        }
        return maxSum;
    }
}*/