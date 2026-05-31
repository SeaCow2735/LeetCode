public class Solution
{
    public int FindClosest(int x, int y, int z)
    {
        int count1 = 0;
        int count2 = 0;
        count1 = Math.Abs(x-z);
        count2 = Math.Abs(y-z);
        if (count1 > count2)
            return 2;
        if (count2 > count1)
            return 1;
        else
            return 0;
    }
}