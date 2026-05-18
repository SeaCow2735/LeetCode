// 744. Find Smallest Letter Greater Than Target
// Given a characters array letters that is sorted in non-decreasing order and a character target, return the smallest character in the array that is larger than target. If such an element does not exist, return the first element of the array.
//My solution (Best solution for run time)
public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        if(letters.Length == 1)
            return letters[0];
        for(int i = 0; i < letters.Length; i++)
        {
            if (letters[i] > target)
                return letters[i];
        }
        return letters[0];
    }
}