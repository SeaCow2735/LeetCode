//My Solution
public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split();
        string[] reversedWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            char[] wordChars = words[i].ToCharArray();
            Array.Reverse(wordChars);
            reversedWords[i] = new string(wordChars);
        }

        return string.Join(" ", reversedWords);
    }
}

//Best solution
public class Solution
{
    public string ReverseWords(string s)
    {
        var array = s.ToCharArray();
        var fInd = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 == s.Length || s[i + 1] == ' ')
            {
                Array.Reverse(array, fInd, i - fInd + 1);
                fInd = i + 2;
            }
        }

        return new string(array);
    }
}