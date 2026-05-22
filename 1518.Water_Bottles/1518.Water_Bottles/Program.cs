// 1518. Water Bottles
// https://leetcode.com/problems/water-bottles/description/
// There are numBottles water bottles that are initially full of water. You can exchange numExchange empty water bottles from the market with one full water bottle.
// The operation of drinking a full water bottle turns it into an empty bottle.
// Given the two integers numBottles and numExchange, return the maximum number of water bottles you can drink.
// My Solution in C#: (best solution for runtime)
// example 1:
/*public class Solution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        if(numBottles < numExchange)
        {
            return numBottles;
        }
        int count = numBottles;
        while(numBottles >= numExchange)
        {
            count += numBottles / numExchange;
            numBottles = numBottles / numExchange + numBottles % numExchange;
        }
        return count;
    }
}*/

// example 2:
public class Solution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        return numBottles + (numBottles - 1) / (numExchange - 1);
    }
}