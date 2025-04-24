using System;

namespace Count_Largest_Group
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            Solution solution = new Solution();
            int value=solution.CountLargestGroup(n);
            Console.WriteLine(value);
        }
        public class Solution {
            public int CountLargestGroup(int n) {
                int counter=0;
                if (n > 10)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (j / 10 == i)
                            {
                                counter++;
                            }
                        }
                    }
                }
                else
                {
                    counter = n;
                }

                return counter;
            }
        }
    }
}