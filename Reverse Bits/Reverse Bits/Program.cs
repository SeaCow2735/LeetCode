// my solution 
/*public class Solution
{
    public uint reverseBits(uint n)
    {
        uint res = 0;
        for (int i = 0; i < 32; i++)
        {
            res = res << 1;        // Shift res left
            res += (n & 1);        // Add the least significant bit of n to res
            n = n >> 1;            // Shift n to the right
        }
        return res;
    }
}*/

//Best solution
/*public class Solution
{
    public int ReverseBits(int n)
    {
        if (n == 0) return n;
        int rev = 0;
        string s = "";
        bool started = false;
        while (n > 1)
        {
            if (n % 2 == 1)
            {
                s += "1";
                started = true;
            }
            else
            {
                if (started) s += "0";
                else rev++;
            }
            n /= 2;
        }
        s = s + "1";
        while (s.Length < 32 - rev)
        {
            s += "0";
        }
        rev = 0;
        foreach (char c in s)
        {
            rev *= 2;
            if (c == '1')
            {
                rev += 1;
            }
        }
        return rev;
    }
}*/