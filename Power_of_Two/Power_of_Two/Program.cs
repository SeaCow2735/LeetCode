namespace Power_of_Two
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPowerOfTwo(3));
        }
            public class Solution1 {
                public bool IsPowerOfTwo(int n) {
                    for (int i = 0; i <= Math.Sqrt(n)+1; i++)
                    {
                        if (Math.Pow(2,i) == n)
                            return true;
                    }
                    return false;
                }
            }
            public class Solution2 {
                public bool IsPowerOfTwo(int n) {
                    if (n <= 0) return false;

                    long x = 1;
                    while (x <= n) {
                        if (x == n) return true;
                        x <<= 1;
                    }
                    return false;
                }
            }

            public class Solution {
                public bool IsPowerOfTwo(int n) {
                    if(n <= 0){
                        return false;
                    }
                    if((n & (n-1)) == 0){
                        return true;  
                    }
                    return false;
                }
            }
    }
}