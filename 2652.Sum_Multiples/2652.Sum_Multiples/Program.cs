// 2652. Sum Multiples
// My solution (not the best runtime solution)
public class Solution
{
    public int SumOfMultiples(int n)
    {
        int sum = 0;
        for(int i = 1; i<=n; i++)
        {
            if(i % 3  == 0 || i % 5 == 0 || i % 7 ==0)
            {
                sum+=i;
            }
        }    
        return sum;
    }
}

// The best runtime solution
/*public class Solution
{
    public int SumOfMultiples(int n)
    {
        return Sum(n, 3) + Sum(n, 5) + Sum(n, 7)
             - Sum(n, 15) - Sum(n, 21) - Sum(n, 35)
             + Sum(n, 105);
    }

    private int Sum(int n, int k)
    {
        var m = n / k;
        return k * m * (m + 1) / 2;
    }
}*/