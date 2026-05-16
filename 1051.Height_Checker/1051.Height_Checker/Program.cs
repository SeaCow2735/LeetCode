// 1051. Height Checker
// Students are asked to stand in non-decreasing order of heights for an annual photo.
// Return the minimum number of students that must move in order for all students to be standing in non-decreasing order of height.
// My Solution (not the best solution for run time)
public class Solution
{
    public int HeightChecker(int[] heights)
    {
        int[] expected = (int[])heights.ToArray();
        Array.Sort(expected);
        int count = 0;
        for(int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expected[i])
            {
                count++;
            }
        }
        return count;
    }
}

// Best Solution
/*public class Solution
{
    public int HeightChecker(int[] heights)
    {
        int[] heightToFreq = new int[101];

        foreach (int height in heights)
        {
            heightToFreq[height]++;
        }

        int result = 0;
        int curHeight = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            while (heightToFreq[curHeight] == 0)
            {
                curHeight++;
            }

            if (curHeight != heights[i])
            {
                result++;
            }
            heightToFreq[curHeight]--;
        }

        return result;
    }
}*/