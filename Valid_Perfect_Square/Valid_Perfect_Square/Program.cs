namespace Valid_Perfect_Square
{
    internal class Program
    { 
        //cái này là my solution
        /*public class Solution {
            public bool IsPerfectSquare(int num) {
                if(num<=1)
                    return true;
                if(num<=3)
                    return false;
                for(int i=num/2;i>=2;i--)
                {
                    if(i*i==num)
                        return true;
                }
                return false;
            }
        }*/
        
        // cái này là best solution (0ms)
        public class Solution {
            public bool IsPerfectSquare(int num) {
                if (num < 0) return false;
                int odd =1;
                while(num>0){
                    num-=odd;
                    odd +=2;
                }
                return num==0;
            }
        }
        public static void Main(string[] args)
        {
        }
    }
}