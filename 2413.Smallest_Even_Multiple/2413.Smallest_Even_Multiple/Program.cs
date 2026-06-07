//2413. Smallest Even Multiple
//My solution (the best runtime solution)
public class Solution
{
    public int SmallestEvenMultiple(int n)
    {
        if (n % 2 == 0)
        {
            return n;
        }
        else
        {
            return 2 * n;
        }
    }
}