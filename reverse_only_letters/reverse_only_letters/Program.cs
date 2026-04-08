public class Solution
{
    public string ReverseOnlyLetters(string s)
    {
        char[] arr = s.ToCharArray();
        int start = 0, end = arr.Length - 1;
        while (start < end)
        {
            if (char.IsLetter(arr[start]) && char.IsLetter(arr[end]))
            {
                (arr[start], arr[end]) = (arr[end], arr[start]);
                start++;
                end--;
            }
            else if (!char.IsLetter(arr[start]))
            {
                start++;
            }
            else
            {
                end--;
            }
        }
        return new string(arr);
    }
}