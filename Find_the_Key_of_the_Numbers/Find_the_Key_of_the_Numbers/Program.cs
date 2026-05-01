// 3270. Find the Key of the Numbers
// You are given three positive integers num1, num2, and num3, each consisting of exactly four digits. The key of the three integers is a four-digit integer that can be obtained by applying the following rules on each set of digits in the same position of num1, num2, and num3:
// - If the digits in the current position of num1, num2, and num3 are the same, the digit in the key will be the same as that digit.
// - If the digits in the current position of num1, num2, and num3 are different, the digit in the key will be 0.
// - If the digits in the current position of num1, num2, and num3 are not all the same but there are two digits that are the same, the digit in the key will be the digit that is repeated.
// Return the key of num1, num2, and num3.
// My Solution (Best Solution for runtime )
// The solution involves extracting each digit from the three numbers, comparing them, and constructing the key based on the given rules. We can achieve this by using arrays to store the digits of each number and then iterating through them to determine the key.
// The time complexity of this solution is O(1) since we are always dealing with a fixed number of digits (4 in this case), and the operations performed are constant time. The space complexity is also O(1) as we are using a fixed amount of space to store the digits and the key.
public class Solution
{
    public int GenerateKey(int num1, int num2, int num3)
    {
        int[] nums1 = new int[4];
        int[] nums2 = new int[4];
        int[] nums3 = new int[4];

        for(int i=3;i>=0;i--)
        {
            nums1[i] = num1%10;
            num1=num1/10;
            nums2[i] = num2 % 10;
            num2 = num2 / 10;
            nums3[i] = num3 % 10;
            num3 = num3 / 10;
        }
        int key = 0;
        int value = 0;
        for(int i=0;i<4;i++)
        {
            value = Math.Min(nums1[i], Math.Min(nums2[i], nums3[i]));
            key = key * 10 + value;
        }
        return key;
    }
}

// Another Solution (Best Solution for memory )
// The solution involves converting the integers to strings, comparing the characters at each position, and constructing the key based on the given rules. This approach is straightforward and easy to understand.
// The time complexity of this solution is O(1) since we are always dealing with a fixed number of digits (4 in this case), and the operations performed are constant time. The space complexity is also O(1) as we are using a fixed amount of space to store the strings and the key.
// The code is commented out to avoid confusion with the first solution. You can uncomment it to use this approach if you prefer it over the first one.
// The solution involves converting the integers to strings, comparing the characters at each position, and constructing the key based on the given rules. This approach is straightforward and easy to understand.
// The time complexity of this solution is O(1) since we are always dealing with a fixed number of digits (4 in this case), and the operations performed are constant time. The space complexity is also O(1) as we are using a fixed amount of space to store the strings and the key.
// The code is commented out to avoid confusion with the first solution. You can uncomment it to use this approach if you prefer it over the first one.
/*public class Solution
{
    public int GenerateKey(int num1, int num2, int num3)
    {
        string s1 = num1.ToString("D4");
        string s2 = num2.ToString("D4");
        string s3 = num3.ToString("D4");

        char[] key = new char[4];

        for (int i = 0; i < 4; i++)
        {
            key[i] = (char)Math.Min(Math.Min(s1[i], s2[i]), s3[i]);
        }

        return int.Parse(new string(key));
    }
}*/