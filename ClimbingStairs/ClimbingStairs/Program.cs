namespace ClimbingStairs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        public class Solution
        {


            public int ClimbStairs(int n)
            {
                if (n <= 3) return n;

                int a = 2;
                int b = 3;
                int result = 0;

                for (int i = 4; i <= n; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }

                return result;
            }
        }

    }
}