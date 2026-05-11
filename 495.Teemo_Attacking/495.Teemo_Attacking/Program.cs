//495. Teemo Attacking
// In LOL world, there is a hero called Teemo and his attacking can make his enemy Ashe be in poisoned condition. Now, given the Teemo's attacking ascending time series towards Ashe and the poisoning time duration per Teemo's attacking, you need to output the total time that Ashe is in poisoned condition.
// You may assume that Teemo attacks at the very beginning of a specific time point, and makes Ashe be in poisoned condition immediately.
// My Solution (not best run time solution)
public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        if (timeSeries.Length == 1)
            return duration;
        int total = 0;
        for(int i = 0; i < timeSeries.Length - 1; i++)
        {
            total += Math.Min(timeSeries[i + 1] - timeSeries[i], duration);
        }
        total += duration;
        return total;
    }
}

//Best run time solution
/*public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        var total = duration;

        for (int i = 1; i < timeSeries.Length; i++)
            total += Math.Min(duration, timeSeries[i] - timeSeries[i - 1]);

        return total;
    }
}*/