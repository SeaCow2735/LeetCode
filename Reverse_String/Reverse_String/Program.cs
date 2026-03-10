namespace Reverse_String
{
    internal class Program
    {
        public class Solution {
            public void ReverseString(char[] s) {
                var l = 0;
                var r = s.Length-1;
                while (l < r)
                {
                    var temp = s[l];
                    s[l] = s[r];
                    s[r] = temp;
                    l++;
                    r--;
                }
            }
        }
        public static void Main(string[] args)
        {
        }
    }
}