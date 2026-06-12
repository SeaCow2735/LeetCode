//3894. Traffic Signal Color
//My solution (the best runtime solution)
public class Solution
{
    public string TrafficSignal(int timer)
    {
        if (timer == 0)
            return "Green";
        if (timer == 30)
            return "Orange";
        if (timer > 30 && timer <= 90)
            return "Red";
        else
            return "Invalid";
    }
}