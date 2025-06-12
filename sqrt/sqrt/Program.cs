namespace sqrt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution {
            public int MySqrt(int x) {
                for(int i=1;i<=x/2;i++)
                {
                    if (i * i == x)
                    {
                        return i;
                    }
                    else if (i * i > x)
                    {
                        return i-1;
                    }
                }
                if(x<2)
                return x;
            }
        }
    }
}