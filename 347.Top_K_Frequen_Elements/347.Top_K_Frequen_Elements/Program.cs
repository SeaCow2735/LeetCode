//My Solution to the problem: https://leetcode.com/problems/top-k-frequent-elements/description/
// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map[nums[i]] = 1;
            }
        }
        var sorted = map.OrderByDescending(x => x.Value);

        int[] result = new int[k];
        int index = 0;
        foreach (var item in sorted)
        {
            result[index] = item.Key;
            index++;

            if (index == k)
            {
                break;
            }
        }

        return result;
    }
}

//Best Solution for running time 
/*public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // build a compact array
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        foreach (int num in nums)
        {
            minValue = Math.Min(minValue, num);
            maxValue = Math.Max(maxValue, num);
        }
        // Console.WriteLine("a");

        // build a frequency array
        int[] freqArray = new int[maxValue - minValue + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            freqArray[nums[i] - minValue]++;
        }
        // Console.WriteLine(" b");

        // simple-traverse for each and collect the top k into the answer array
        int[] ans = new int[k];
        int maxFreq, maxValOfFreq;
        for (int ansIndex = 0; ansIndex < ans.Length; ansIndex++)
        {
            maxFreq = int.MinValue;
            maxValOfFreq = int.MinValue;
            // Console.WriteLine("  c");
            for (int valIndex = 0; valIndex < freqArray.Length; valIndex++)
            {
                // Console.WriteLine("   d");
                if (maxFreq < freqArray[valIndex])
                {
                    maxFreq = freqArray[valIndex];
                    maxValOfFreq = valIndex;
                }
            }

            freqArray[maxValOfFreq] = -1;
            ans[ansIndex] = maxValOfFreq + minValue;
        }
        // Console.WriteLine("    e");

        return ans;
    }
}*/