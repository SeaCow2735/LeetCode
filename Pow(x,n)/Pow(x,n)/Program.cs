
// 50. Pow(x, n) 
// My Solution (Best Solution for running time)
public class Solution
{
    public double MyPow(double x, int n)
    {
        long power = n;
        if(x == 0)
            return 0;
        if(n == 0)
            return 1;
        if(n<0 )
        {
                x = 1 / x;
                power = -power;         
        }
        
        double result = 1;
        double baseProduct = x;
        int count = 0;
        while (power > 0)
        {
            if(power % 2 != 0)
            {
                result *= baseProduct;
            }
            baseProduct *= baseProduct;
            power /= 2;
        }
        return result;
    }
}

// Easier to do but not the best solution to impress the interviewer (IDK but not very impressed to me but kinda fun and interesting)
/*public class Solution
{
    public double MyPow(double x, int n)
    {
        Math.Pow(x, n);
    }
}*/