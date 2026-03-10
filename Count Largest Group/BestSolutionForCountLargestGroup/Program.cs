using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    List<List<int>> refList = new List<List<int>> {
        new List<int> { 1 },
        Enumerable.Repeat(0, 10).ToList(),
        Enumerable.Repeat(0, 19).ToList(),
        Enumerable.Repeat(0, 28).ToList()
    };

    public int CountLargestGroup(int n) {
        int[] digits = new int[4];
        int[] counts = new int[37];
        int power = 0, psum = 0;

        for (int num = Math.Min(n, 9999); num > 0; num /= 10) {
            int digit = num % 10;
            psum += (digits[power] += digit);
            power++;
        }

        for (int d = 0; d < power; d++) {
            int digit = digits[d];
            int prevSize = refList[d].Count;
            int currSize = (d > 2 || refList[d + 1].Last() != 0) ? 0 : refList[d + 1].Count;
            int limit = Math.Max(d * 9 + digit, currSize);
            psum -= digit;

            for (int i = 0, val = 0; i < limit; i++) {
                val += (i < prevSize ? refList[d][i] : 0)
                       - (i >= digit && i - digit < prevSize ? refList[d][i - digit] : 0);

                counts[psum + i] += val;

                if (currSize > 0) {
                    int prevVal = (i > 0 && i - 1 < currSize) ? refList[d + 1][i - 1] : 0;
                    int refVal = (i < prevSize) ? refList[d][i] : 0;
                    int refPrev = (i >= 10 && i - 10 < prevSize) ? refList[d][i - 10] : 0;

                    refList[d + 1][i] = prevVal + refVal - refPrev;
                }
            }
        }

        counts[0] = 0;
        return counts.Max(count => count);
    }
}