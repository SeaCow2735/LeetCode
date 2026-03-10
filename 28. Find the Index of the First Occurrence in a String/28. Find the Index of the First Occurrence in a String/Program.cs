namespace _28._Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution {
            public int StrStr(string haystack, string needle) {
                if (needle == "") return 0;
                if (needle.Length > haystack.Length) return -1;

                for (int i = 0; i <= haystack.Length - needle.Length; i++) {
                    if (haystack.Substring(i, needle.Length) == needle) {
                        return i;
                    }
                }
                return -1;
            }

        }
    }
}