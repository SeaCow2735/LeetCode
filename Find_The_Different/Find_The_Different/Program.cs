//My Solution

/*public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        var sortedS = s.OrderBy(c => c).ToArray();
        var sortedT = t.OrderBy(c => c).ToArray();

        for (int i = 0; i < s.Length; i++)
        {
            if (sortedS[i] != sortedT[i])
            {
                return sortedT[i];
            }
        }
        return sortedT[t.Length - 1];
    }
}*/


// Best Solution

/*public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        int result = 0;

        foreach (char c in s)
            result ^= c;

        foreach (char c in t)
            result ^= c;

        return (char)result;
    }
}*/