// 3898. Find the Degree of Each Vertex
// My solution (best runtime solution)
using System;

public class Solution
{
    public int[] FindDegrees(int[][] matrix)
    {
        int[] result = new int[matrix.Length];

        for (int i = 0; i < matrix.Length; i++)
        {
            int sum = 0;

            foreach (int num in matrix[i])
            {
                sum += num;
            }

            result[i] = sum;
        }

        return result;
    }
}