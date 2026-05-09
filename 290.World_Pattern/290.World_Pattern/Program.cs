// 290. Word Pattern
// Given a pattern and a string s, find if s follows the same pattern.
// Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
// My Solution is to use two dictionaries to maintain the mapping between characters in pattern and words in s.
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] words = s.Split(' ');

        if (pattern.Length != words.Length)
        {
            return false;
        }

        Dictionary<char, string> charToWord = new Dictionary<char, string>();
        Dictionary<string, char> wordToChar = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++)
        {
            char c = pattern[i];
            string word = words[i];

            if (charToWord.ContainsKey(c))
            {
                if (charToWord[c] != word)
                {
                    return false;
                }
            }
            else
            {
                charToWord[c] = word;
            }

            if (wordToChar.ContainsKey(word))
            {
                if (wordToChar[word] != c)
                {
                    return false;
                }
            }
            else
            {
                wordToChar[word] = c;
            }
        }

        return true;
    }
}


// Best Solution for running time 
/*public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] arr = s.Split(' ');
        if (pattern.Length != arr.Length)
        {
            return false;
        }
        Dictionary<char, string> dict = new Dictionary<char, string>();
        for (int i = 0; i < arr.Length; i++)
        {
            char c = pattern[i];
            string s1 = arr[i];
            if (dict.ContainsKey(c))
            {
                if (!s1.Equals(dict[c]))
                {
                    return false;
                }
            }
            else if (dict.ContainsValue(s1))
            {
                return false;
            }
            else
            {
                dict.Add(c, s1);
            }
        }
        return true;
    }
}*/