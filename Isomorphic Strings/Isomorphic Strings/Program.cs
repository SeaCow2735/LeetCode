namespace IsomorphicStrings;
public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        int[] mapS = new int[256];
        int[] mapT = new int[256];
        for (int i = 0; i < s.Length; i++)
        {
            if (mapS[s[i]] != mapT[t[i]])
            {
                return false;
            }
            mapS[s[i]] = i + 1;
            mapT[t[i]] = i + 1;
        }
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        Console.WriteLine(s.IsIsomorphic(str1,str2));
       
    }
}