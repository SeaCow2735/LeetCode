namespace First_Unique_Character_in_a_String
{
    internal class Program
    {
        //My solution
        /*public class Solution {
            public int FirstUniqChar(string s) {
                 int[] letters = new int[26];
                foreach(char c in s)
                    letters[c - 'a']++;
                for(int i=0;i<s.Length;i++)
                {
                    if(letters[s[i]-'a']==1)
                    return i;
                }
                return -1;
            }
        }*/
        
        //Best solution
        /*public class Solution {
            public int FirstUniqChar(string s) 
            {
                int result = s.Length;

                for(char letter = 'a'; letter <='z';  letter++)
                {
                    var first = s.IndexOf(letter);
                    if (first == -1) continue;

                    var last = s.LastIndexOf(letter);
                    if (last > result) continue;

                    if (first == last) result = first;
                }

                return result == s.Length
                    ? -1
                    : result;
            }
        }*/
        public static void Main(string[] args)
        {
        }
    }
}