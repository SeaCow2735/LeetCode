// 2942. Find Words Containing Character
// My solution (the best runtime solution)
public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var result = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))
            {
                result.Add(i);
            }
        }
        return result;
    }
}



