//3174. Clear Digits
//My solution (the best runtime solution)
using System.Text;

public class Solution
{
    public string ClearDigits(string s)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char ch in s)
        {
            if (char.IsDigit(ch))
            {
                if (sb.Length > 0)
                    sb.Remove(sb.Length - 1, 1);
            }
            else
            {
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }
}