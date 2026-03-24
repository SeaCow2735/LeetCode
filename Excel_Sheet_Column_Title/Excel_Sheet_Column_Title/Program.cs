using System.Linq;
using System.Text;

namespace Excel_Sheet_Column_Title
{
    internal class Program
    {   //My solution
        /*public class Solution {
            public string ConvertToTitle(int columnNumber) {
                var ans = new StringBuilder();
                while(columnNumber >0)
                {
                    columnNumber--;
                    ans.Append((char)((columnNumber % 26) + 'A'));
                    columnNumber /= 26;
                }
                return new string (ans.ToString().Reverse().ToArray());
            }
        }*/
        
        //Best solution
        public class Solution {
            public string ConvertToTitle(int columnNumber)
            {
                var stringbuilder = new StringBuilder();
                while (columnNumber > 0)
                {
                    var reminder = columnNumber % 26; // we get rightmost digit
                    var character = reminder == 0 ? 'Z' : (char)('A' + reminder - 1);// ouser is 0 indexed but excel is 1 indexed thats why we subtract one
                    stringbuilder.Insert(0, character); // we insert at the beggining as to not reverse later on
                    columnNumber = reminder == 0 ? columnNumber / 26 - 1 : columnNumber / 26;// if reminder is 0 we used up that column so if we just divide on 26 we get 1 but we already used it so we subtract 1
                }

                return stringbuilder.ToString();
            }
        }
        public static void Main(string[] args)
        {
        }
    }
}