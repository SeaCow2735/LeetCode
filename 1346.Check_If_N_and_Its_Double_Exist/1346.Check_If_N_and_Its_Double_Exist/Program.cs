// 1346. Check If N and Its Double Exist
// Given an array arr of integers, check if there exist two indices i and j such that : 
// i != j
// 0 <= i, j < arr.length
// arr[i] == 2 * arr[j]
// My solution is a brute-force approach that checks all possible pairs of indices in the array to see if the condition arr[i] == 2 * arr[j] holds true. If such a pair is found, it returns true; otherwise, it continues checking until all pairs have been evaluated. If no such pair is found after checking all possibilities, it returns false.
// Time complexity: O(n^2) - We have two nested loops that iterate through the array, resulting in a quadratic time complexity.
// Space complexity: O(1) - We are using a constant amount of extra space to store the result variable, regardless of the input size.
/*public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        bool result = false;
        for(int i= 0; i < arr.Length; i++) {
            for(int j= 0; j < arr.Length; j++) {
                if(i != j && arr[i] == 2 * arr[j]) {
                    result = true;
                    break;
                }
            }
            if(result) {
                break;
            }
        }
        return result;
    }
}*/

// Best solution: 
public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (d.ContainsKey(arr[i] * 2)) return true;
            if (arr[i] % 2 == 0 && d.ContainsKey(arr[i] / 2)) return true;
            d[arr[i]] = 1;
        }

        return (false);
    }
}