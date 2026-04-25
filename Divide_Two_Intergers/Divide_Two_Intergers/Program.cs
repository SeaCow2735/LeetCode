public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }

        long num1 = Math.Abs((long)dividend);
        long num2 = Math.Abs((long)divisor);

        int result = 0;

        while (num1 >= num2)
        {
            long temp = num2;
            int multiple = 1;

            while (num1 >= temp + temp)
            {
                temp += temp;
                multiple += multiple;
            }

            num1 -= temp;
            result += multiple;
        }

        return (dividend > 0) == (divisor > 0) ? result : -result;
    }
}