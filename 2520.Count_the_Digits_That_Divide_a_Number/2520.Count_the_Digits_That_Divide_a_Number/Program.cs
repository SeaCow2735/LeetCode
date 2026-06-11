//2520. Count the Digits That Divide a Number
//My solution (the best runtime solution)
public class Solution
{
    public int CountDigits(int num)
    {
        int temp = num;
        int temp2 = 0;
        int count = 0;
        while(temp!=0)
        {
            temp2 = temp % 10;
            if(num%temp2==0)
            {
                count++;
            }
            temp = temp / 10;
        }
        return count;
    }
}