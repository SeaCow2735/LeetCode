namespace Majority_Element
{
    internal class Program
    {   //Best solution
        public class Solution {
            public int MajorityElement(int[] nums) {
                int ele = nums[0];
                int count = 1;

                for (int i = 1; i < nums.Length; i++)
                {
                    if (count == 0)
                    {
                        ele = nums[i];
                        count = 1;
                    }
                    else if (ele == nums[i])
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }

                return ele;
            }
        }

        public static void Main(string[] args)
        {
            
        }
    }
}

