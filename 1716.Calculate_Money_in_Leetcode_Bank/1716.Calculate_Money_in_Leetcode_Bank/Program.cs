//My Solution
public class Solution
{
    public int TotalMoney(int n)
    {
        int total = 0;
        int lastMonday = 0;
        int current = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i % 7 == 1)
            {
                lastMonday++;
                current = 0;
            }
            total = total + lastMonday + current;
            current++;
        }
        return total;
    }
}