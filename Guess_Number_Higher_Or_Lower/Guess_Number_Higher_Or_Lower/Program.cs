// my solution
/**
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

/*public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int start = 1, end = n, middle = -1; 
        while(start <= end){
            middle = start + (end - start) / 2;
            switch(guess(middle)){
                case 1:
                    start = middle + 1;
                    break;
                case -1:
                    end = middle - 1;
                    break;
                case 0:
                    return middle;
            }
           
        }
        return -1;
    }
}*/

//best solution
/**
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

/*public class Solution : GuessGame {
    public int GuessNumber(int n)
    {
        var res = int.MinValue;
        var left = 0;
        var right = n;
        while (res != 0)
        {
            var mid = left + (right - left) / 2;
            res = guess(mid);
            if (res == 0)
            {
                return mid;
            }
            else if (res == 1)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return int.MinValue;
    }

}*/