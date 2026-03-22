namespace Perfect_Number
{
    internal class Program
    {
        //My solution
        /*public class Solution {
            public bool CheckPerfectNumber(int num) {
                if(num <=3)
                    return false;
                int count =1;
                for(int i=2;i<=num/2+1;i++)
                {
                    if(num%i==0)
                        count+=i;
                }
                return count==num;
            }
        }*/
        
        //Best solution
        public class Solution {
            public bool CheckPerfectNumber(int num) {
                if (num % 2 != 0) return false;
                int total = 0;
                for (int i = 1; i * i <= num; i++) {
                    if (num % i != 0) continue;
                    if (i == 1) {
                        total += i;
                    } else {
                        total += i + num / i;
                    }
                }
                return total == num;
            }
        }
        public static void Main(string[] args)
        {
        }
    }
}