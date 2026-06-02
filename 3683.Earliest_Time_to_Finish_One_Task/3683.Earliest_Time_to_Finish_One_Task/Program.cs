//3683. Earliest Time to Finish One Task
// My solution (the best runtime solution)
public class Solution
{
    public int EarliestTime(int[][] tasks)
    {
        int result = tasks[0][0] + tasks[0][1];
        for (int i = 1; i < tasks.Length; i++)
        {
            int[] currentTask = tasks[i];
            result = Math.Min(result, currentTask[0] + currentTask[1]);
        }

        return result;
    }
}