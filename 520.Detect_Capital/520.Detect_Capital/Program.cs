// 520. Detect Capital
// Given a word, you need to judge whether the usage of capitals in it is right or not. We define the usage of capitals in a word to be right when one of the following cases holds:
// 1. All letters in this word are capitals, like "USA".
// 2. All letters in this word are not capitals, like "leetcode".
// 3. Only the first letter in this word is capital, like "Google".
// Otherwise, we define that this word doesn't use capitals in a right way.
// My solution (Best solution for running time) is to count the number of capital letters in the word and then check if it matches one of the three valid cases.
// This approach runs in O(n) time, where n is the length of the word, since we need to iterate through each character once to count the capitals.
// The space complexity is O(1) since we only use a constant amount of extra space for the count variable.
public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        int count = 0;
        if(word.Length == 1)
            return true;
        for(int i = 0; i < word.Length; i++)
        {
            if(word[i] >= 'A' && word[i] <= 'Z')
                count++;
        }
        if(count == word.Length || count == 0)
            return true;
        if(count == 1 && word[0] >= 'A' && word[0] <= 'Z')
            return true;
        else
            return false;
    }
}