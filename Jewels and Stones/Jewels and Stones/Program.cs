// My first solution to the problem "Jewels and Stones" on LeetCode.
/*public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        char[] jews = jewels.ToCharArray();
        int count = 0;
        foreach (char s in stones)
        {
            foreach (char c in jews)
            {
                if (s == c)
                {
                    count++;
                }
            }
        }
        return count;
    }
}*/


//My best solution to the problem "Jewels and Stones" on LeetCode.
public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        var jewelSet = new HashSet<char>(jewels);
        int count = 0;
        foreach (char s in stones)
        {
            if (jewelSet.Contains(s))
            {
                count++;
            }
        }
        return count;
    }
}