// 1952. Three Divisors
// My solution (not the best runtime solution)
/*public class Solution
{
    public bool IsThree(int n)
    {
        int n1 = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                n1++;
            }
        }
        return n1 == 3;
    }
}*/

// Best Solution
public class Solution
{
    public bool IsThree(int n)
    {
        // Əgər n 4-dən kiçikdirsə, 3 böləni ola bilməz (1-in 1, 2-nin 2, 3-ün 2 böləni var)
        if (n < 4) return false;

        int root = (int)System.Math.Sqrt(n);

        // n-in tam kvadrat kökü olmalıdır və həmin kök sadə ədəd olmalıdır
        if (root * root != n) return false;

        return IsPrime(root);
    }

    private bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}