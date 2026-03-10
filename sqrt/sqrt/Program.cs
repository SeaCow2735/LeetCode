namespace sqrt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public class Solution {
            public int MySqrt(int x) {
                if (x == 0) return 0;
                if (x == 1) return 1;
                var start = 0;
                var end = x;

                while (start <= end)
                {
                    var mid = (start + end) / 2;
                    var square = (long)mid*mid;

                    if (square < x)
                    {
                        start = mid + 1;
                    }
                    else if (square > x)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        return mid;
                    }
                }

                return end;
            }
        }
    }
}