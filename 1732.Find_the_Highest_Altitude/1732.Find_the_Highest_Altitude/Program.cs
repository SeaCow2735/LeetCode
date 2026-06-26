// 1732. Find the Highest Altitude
// My Solution (the best runtime solution)
public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        int Max = 0;
        int temp = 0;
        for (int i =0;i<gain.Length;i++)
        {
            temp+= gain[i];
            if(temp > Max) Max = temp;
        }
        return Max;

    }
}