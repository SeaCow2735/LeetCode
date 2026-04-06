//My solution 
/*public class Solution
{
    public bool HasGroupsSizeX(int[] deck)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int n in deck)
        {

            counts.TryGetValue(n, out int c);
            counts[n] = c + 1;
        }

        int x = 0;

        foreach (int c in counts.Values)
        {

            x = gcd(x, c);
        }

        return x != 1;
    }

    private static int gcd(int a, int b)
    {
        if (a < b) return gcd(b, a);
        if (b == 0) return a;

        return gcd(b, a % b);
    }
}*/

//Best Solution
public class Solution
{
    public bool HasGroupsSizeX(int[] deck)
    {
        if (deck.Length < 2)
            return false;

        int max = deck[0];
        for (int i = 1; i < deck.Length; i++)
            if (deck[i] > max)
                max = deck[i];
        int[] count = new int[max + 1];
        for (int i = 0; i < deck.Length; i++)
            count[deck[i]]++;
        for (int x = 2; x <= deck.Length; x++)
        {
            bool can = true;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0 && count[i] % x != 0)
                {
                    can = false;
                    break;
                }
            }
            if (can)
                return true;
        }

        return false;
    }
}