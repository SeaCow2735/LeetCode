using System.Text;
//My Solution
/*public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        StringBuilder result = new StringBuilder();
        int i = num1.Length - 1;
        int j = num2.Length - 1;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int n1 = i >= 0 ? num1[i] - '0' : 0;
            int n2 = j >= 0 ? num2[j] - '0' : 0;

            int sum = n1 + n2 + carry;
            result.Append(sum % 10);
            carry = sum / 10;

            i--;
            j--;
        }

        char[] charArray = result.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}*/

// Best Solution
/*public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        var carry = 0;
        if (num1.Length < num2.Length)
            (num1, num2) = (num2, num1);
        Span<char> result = stackalloc char[num1.Length + 1];

        var i = 1;
        for (; i <= num2.Length; i++)
        {
            var d = num1[^i] + num2[^i] + carry - 2 * '0';
            carry = d / 10;
            result[^i] = (char)(d % 10 + '0');
        }
        for (; i <= num1.Length; i++)
        {
            var d = num1[^i] + carry - '0';
            carry = d / 10;
            result[^i] = (char)(d % 10 + '0');
        }
        if (carry != 0)
            result[0] = (char)(carry + '0');

        return new(result.Slice(carry == 0 ? 1 : 0));
    }
}*/