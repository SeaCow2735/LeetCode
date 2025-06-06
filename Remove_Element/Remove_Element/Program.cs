namespace Remove_Element
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
        public class Solution {
            public int RemoveElement(int[] nums, int val) {
                if (nums == null || nums.Length == 0)
                    return 0;
                int k = 0; 

                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] != val) {
                        nums[k] = nums[i]; 
                        k++;
                    }
                }
                return k;
            }
            
        }
        
    }
}
