//1431. Kids With the Greatest Number of Candies
//My solution (not the best solution for runtime)
/*public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        bool[] result = new bool[candies.Length];
        int temp = 0;
        int max = candies.Max();
        for(int i = 0; i < candies.Length; i++)
        {
            temp = candies[i] + extraCandies;
            if(temp>=max)
            {
                result[i] = true;
                continue;
            }
            result[i] = false;
        }
        return result;
    }
}*/
//The best runtime solution
public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int i;

        int maxCandies = candies[0];

        for (i = 0; i < candies.Length; i++)
        {
            if (candies[i] > maxCandies)
            {
                maxCandies = candies[i];
            }

        }

        List<bool> result = new List<bool>();

        for (i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= maxCandies)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }

        return result;

    }
}