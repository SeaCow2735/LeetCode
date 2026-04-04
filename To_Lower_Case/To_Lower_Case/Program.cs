//My Solution
/*public class Solution
{
    public string ToLowerCase(string s)
    {
        return s.ToLowerInvariant();
    }
}*/
//Best Solution
/*public class Solution
{
    public string ToLowerCase(string s)
    {
        int len = s.Length;
        StringBuilder strBuilder = new StringBuilder();
        for (int i = 0; i < len; i++)
        {
            int ascii = (int)s[i];
            if (ascii >= 65 && ascii <= 90)
            {
                ascii += 32;
                char a = (char)ascii;
                strBuilder.Append(a);
            }
            else
            {
                char a = (char)ascii;
                strBuilder.Append(a);
            }
        }
        return strBuilder.ToString();
    }
}*/