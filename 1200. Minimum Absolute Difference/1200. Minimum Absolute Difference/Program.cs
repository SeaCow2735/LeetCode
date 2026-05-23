
// 1200. Minimum Absolute Difference
// My Solution
using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);

        int minDiff = int.MaxValue;

        IList<IList<int>> res = new List<IList<int>>();

        for (int i = 1; i < arr.Length; i++)
        {
            int diff = arr[i] - arr[i - 1];

            if (diff < minDiff)
            {
                minDiff = diff;

                res = new List<IList<int>>();

                res.Add(new List<int> { arr[i - 1], arr[i] });
            }
            else if (diff == minDiff)
            {
                res.Add(new List<int> { arr[i - 1], arr[i] });
            }
        }

        return res;
    }
}

// Best Solution for run time
/*public class Solution
{
    public IList<IList<int>> MinimumAbsDifference(int[] InputArray)
    {
        int MinValue = InputArray[0];
        int MaxValue = InputArray[0];

        for (int Index = 1; Index < InputArray.Length; ++Index)
        {
            int CurrentNumber = InputArray[Index];
            MinValue = Math.Min(MinValue, CurrentNumber);
            MaxValue = Math.Max(MaxValue, CurrentNumber);
        }

        int ValueRange = MaxValue - MinValue;
        bool[] NumberExists = new bool[ValueRange + 1];

        for (int Index = 0; Index < InputArray.Length; ++Index)
        {
            NumberExists[InputArray[Index] - MinValue] = true;
        }

        var ResultPairs = new List<IList<int>>();
        int PreviousValue = MinValue;
        int MinDifference = ValueRange;

        for (int Offset = 1; Offset < NumberExists.Length; ++Offset)
        {
            if (!NumberExists[Offset])
            {
                continue;
            }

            int CurrentValue = MinValue + Offset;
            int CurrentDifference = CurrentValue - PreviousValue;
            int LeftValue = PreviousValue;

            PreviousValue = CurrentValue;

            if (CurrentDifference > MinDifference)
            {
                continue;
            }

            if (CurrentDifference < MinDifference)
            {
                MinDifference = CurrentDifference;
                ResultPairs.Clear();
            }

            ResultPairs.Add(new int[] { LeftValue, CurrentValue });
        }

        return ResultPairs;
    }
}*/