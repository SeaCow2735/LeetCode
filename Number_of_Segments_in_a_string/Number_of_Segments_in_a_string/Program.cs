using System;

namespace Number_of_Segments_in_a_string
{
    internal class Program
    {
        public class Solution {
            public int CountSegments(string s) {
                int space=0;
                if(s.Length==0)
                    return 0;
                for(int i=0;i<s.Length;i++)
                {
                    if(s[i]==' ')
                        space++;
                }
                if(space ==s.Length)
                    return 0;
                space = 0;
                for(int i=0;i<s.Length;i++)
                {
                    if (s[i] == ' ' && i == s.Length - 1)
                        break;
                    if (s[i] == ' ' && s[i + 1] != ' ')
                        space++;
                }
                if(space==0)
                    return 1;

                if (s[0] != ' ')
                    return space + 1;
                else
                    return space;
            }
        }
        
        //best solution 
        /*public class Solution {
            public int CountSegments(string s) {
                int count = 0;
                bool countBegin = false;

                for(int i = 0 ; i < s.Length; i++)
                {
                    if(s[i] == ' ')
                    {
                        countBegin = false;
                    }
                    if(s[i] != ' ')
                    {
                        if(!countBegin)
                        {
                            count++;
                        }
                        countBegin = true;
                    }
                }
                return count;
            }
        }*/
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.CountSegments("    foo    bar");
        }
    }
}