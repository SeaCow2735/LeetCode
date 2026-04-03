using System;

namespace Palindrome_Number
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution {
            public bool IsPalindrome(int x) {
                // Negative numbers are not palindromes
                if (x < 0) return false;

                string s = x.ToString();
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                string reversed = new string(arr);

                return s == reversed;
            }
        }
    }
}