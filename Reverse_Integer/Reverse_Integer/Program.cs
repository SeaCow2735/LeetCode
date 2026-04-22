//My Solution to the problem: https://leetcode.com/problems/reverse-integer/description/
/*public class Solution
{
    public int Reverse(int x)
    {
        int result = 0;

        while (x != 0)
        {
            int digit = x % 10;
            x = x / 10;

            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
            {
                return 0;
            }

            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8))
            {
                return 0;
            }

            result = result * 10 + digit;
        }

        return result;
    }
}*/

//Best Solution to the problem: https://leetcode.com/problems/reverse-integer/description/
public class Solution
{
    public int Reverse(int x)
    {
        int result = 0;

        while (x != 0)
        {
            int digit = x % 10;

            if (result > int.MaxValue / 10 || result < int.MinValue / 10)
                return 0;

            result = result * 10 + digit;
            x /= 10;
        }
        return result;
    }
}