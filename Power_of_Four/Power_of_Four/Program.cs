//My Solution
/*public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if (n <= 0)
            return false;
        for (int i = 0; i <= Math.Sqrt(n); i++)
        {
            if (Math.Pow(4, i) == n)
                return true;
        }
        return false;
    }
}*/

//Best Solution
public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        else
        {
            if ((n & (n - 1)) == 0 && n % 3 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}