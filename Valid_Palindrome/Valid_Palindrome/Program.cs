using System;

namespace Valid_Palindrome
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.Write(IsPalindrome(s));
        }
        public class Solution {
            public bool IsPalindrome(string s)
            {
                string result="";
                int i = 0;
                char temp;
                while (i < s.Length)
                {
                    if (s[i] >= 'a' && s[i] <= 'z')
                    {
                        result += s.Substring(i, 1);
                    }
                    else if (s[i] >= 'A' && s[i] <= 'Z')
                    {
                        temp = s[i];
                        temp = char.ToLower(temp);
                        result +=temp.ToString();
                    }

                    if (s[i] >= '0' && s[i] <= '9')
                    {
                        result += s.Substring(i, 1);
                    }

                    i++;
                }
                char[] charArray = result.ToCharArray();
                Array.Reverse(charArray);
                string reverse = new string(charArray);
                return reverse == result;
            }
        }
    }
}
// public class Solution {
//     public bool IsPalindrome(string s) {
//         int p1 = 0;
//         int p2 = s.Length-1;
//
//
//
//         while (p1 < p2){            
//
//             if (!char.IsLetterOrDigit(s[p1])) {
//                 p1++;
//                 continue;
//             }
//
//             if (!char.IsLetterOrDigit(s[p2])){
//                 p2--;
//                 continue;
//             }
//
//             if (char.ToUpper(s[p1]) == char.ToUpper(s[p2])){
//                 p1++;
//                 p2--;
//             } else return false;
//         }
//
//         return true;
//     }
// }

// using System.Text;
//
// public class Solution {
//     public bool IsPalindrome(string s)
//     {
//         StringBuilder result = new StringBuilder();
//
//         foreach (char c in s)
//         {
//             if (char.IsLetterOrDigit(c))
//             {
//                 result.Append(char.ToLower(c));
//             }
//         }
//
//         string clean = result.ToString();
//         char[] arr = clean.ToCharArray();
//         Array.Reverse(arr);
//         string reversed = new string(arr);
//
//         return clean == reversed;
//     }
// }
