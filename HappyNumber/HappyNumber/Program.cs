namespace HappyNumber
{
    internal class Program
    {
        public class Solution
        {
            public bool IsHappy(int n)
            {
                if (squareSum(n) == 1)
                    return true;
                else
                {
                    while (squareSum(n) != 1)
                    {
                        n = squareSum(n);
                        if (n == 4)
                            return false;
                    }
                    return true;
                }
            }
            public int squareSum(int n)
            {
                int sum = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    sum += digit * digit;
                    n /= 10;
                }
                sum += n*n;
                return sum;
            }
        }
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int n;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            bool result = solution.IsHappy(n);
            Console.WriteLine("Input: n = " + n);
            Console.WriteLine(result);
        }
        
    }
}