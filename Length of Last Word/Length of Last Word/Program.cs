namespace Length_of_Last_Word
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution {
            public int LengthOfLastWord(string s)
            {
                if (s.Length == 0)
                {
                    return 0;
                }

                int cc=0;
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] != ' ')
                    {
                        cc++;
                    }
                    else if (cc > 0)
                    {
                        break;
                    }
                }
                return cc;
            }
        }
    }
}