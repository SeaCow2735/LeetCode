namespace First_Bad_Version
{
    internal class Program
    {
        /* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

        public class Solution : VersionControl {
            public int FirstBadVersion(int n) {
                int left = 1;
                int right = n;

                while (left <= right)
                {
                    int mid = left + ((right-left)/2);  // This avoids int overflow
                    //Console.WriteLine($"{left}:{right}-> {mid}");

                    if (IsBadVersion(mid))
                    {
                        if (IsBadVersion(mid - 1))
                        {
                            right = mid - 1;
                        }
                        else
                        {
                            return mid;
                        }
                    }
                    else
                    {
                        if (IsBadVersion(mid+1))
                        {
                            return mid + 1;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }
                }

                return - 1;
            }
        }
        public static void Main(string[] args)
        {
        }
    }
}