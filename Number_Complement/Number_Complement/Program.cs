// Given a positive integer num, output its complement number. The complement strategy is to flip the bits of its binary representation.
// My solution is to create a mask that has the same number of bits as num, but all bits are set to 1. Then, I can XOR num with the mask to get the complement.
// For example, if num is 5 (binary 101), the mask would be 7 (binary 111). XORing 5 with 7 gives us 2 (binary 010), which is the complement of 5. 
// The time complexity of this solution is O(log n), where n is the value of num, because we need to determine the number of bits in num to create the mask. The space complexity is O(1) since we are using a constant amount of space for the mask and temporary variables.
public class Solution
{
    public int FindComplement(int num)
    {
        if (num == 0) return 1;

        int mask = 0;
        int temp = num;
        while (temp > 0)
        {
            mask = (mask << 1) | 1;
            temp >>= 1;
        }

        return num ^ mask;
    }
}