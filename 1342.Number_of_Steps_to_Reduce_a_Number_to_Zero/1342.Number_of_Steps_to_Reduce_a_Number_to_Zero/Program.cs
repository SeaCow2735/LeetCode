// 1342. Number of Steps to Reduce a Number to Zero
// My solution (the best runtime solution)
public class Solution
{
    public int NumberOfSteps(int num)
    {
        int count = 0;
        while(num!=0)
        {
            if (num % 2 == 0)
            {
                count++;
                num = num / 2;
            }
            else
            {
                num--;
                count++;
            }
        }
        return count;

    }
}