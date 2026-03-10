using System;

namespace Roman_to_Integer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Solution solution = new Solution();
            Console.WriteLine();
            Console.Write(solution.RomanToInt(s));
        }
        public class Solution {
            public int RomanToInt(string s) {
                int result = 0;
                int prev = 0;

                for (int i = s.Length - 1; i >= 0; i--) {
                    int current = 0;
                    switch (s[i]) {
                        case 'I':
                            current = 1;
                            break;
                        case 'V':
                            current = 5;
                            break;
                        case 'X':
                            current = 10;
                            break;
                        case 'L':
                            current = 50;
                            break;
                        case 'C':
                            current = 100;
                            break;
                        case 'D':
                            current = 500;
                            break;
                        case 'M':
                            current = 1000;
                            break;
                    }

                    
                    if (current < prev) {
                        result -= current;
                    } else {
                        result += current;
                    }

                    prev = current;
                }

                return result;
            }
        }
    }
}


/*//public class Solution {
    /*
    public int RomanToInt(string s) {
        int sum = 0;
        for(int i = 0; i < s.Length; i++) {
            if(s[i] == 'I') {
                // use modulus operator on count?
                if(i < s.Length - 1) {
                    if(s[i+1] == 'V' || s[i+1] == 'X') {
                        sum--;
                    } else {
                        sum++;
                    }
                } else {
                    sum++;
                }
            } else if(s[i] == 'V') {
                sum+=5;
            } else if(s[i] == 'X') {
                if(i < s.Length - 1) {
                    if(s[i+1] == 'L' || s[i+1] == 'C') {
                        sum-=10;
                    } else {
                        sum+=10;
                    }
                } else {
                    sum+=10;
                }
            } else if(s[i] == 'L') {
                sum+=50;
            } else if(s[i] == 'C') {
                if(i < s.Length - 1) {
                    if(s[i+1] == 'D' || s[i+1] == 'M') {
                        sum-=100;
                    } else {
                        sum+=100;
                    }
                } else {
                    sum+=100;
                }
            } else if(s[i] == 'D') {
                sum+=500;
            } else if(s[i] == 'M') {
                sum+=1000;
            }
        }
        return sum;
    }
    #1#
    /*
    public int RomanToInt(string s) {
        Dictionary<char, int> m = new Dictionary<char, int>
        {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
        };

        int sum = m[s[^1]];
        for(int i = s.Length - 2; i >= 0; i--) {
            if(m[s[i]] < m[s[i+1]]) {
                sum-=m[s[i]];
            } else {
                sum+=m[s[i]];
            }
        }
        return sum;
    }
}
#1#

public class Solution {
    private static int[] mappingTable;

    static Solution(){
        mappingTable = new int[200];
        mappingTable['I'] = 1;
        mappingTable['V'] = 5;
        mappingTable['X'] = 10;
        mappingTable['L'] = 50;
        mappingTable['C'] = 100;
        mappingTable['D'] = 500;
        mappingTable['M'] = 1000;
    }
    public int RomanToInt(string s) {
        
var sum = 0;
int numberToCompare = 1;
for (int i = s.Length - 1; i >= 0; i--)
{
    var numCurrentVal = mappingTable[s[i]]; 
    if (numCurrentVal >= numberToCompare)
    {
        sum += numCurrentVal;
        numberToCompare = numCurrentVal;
    }
    else
    {
        sum -= numCurrentVal;
    }
}
return sum;
    }
}

// Problem is simpler to solve by working the string from back to front and using a map.






// for(int i = 0; i < s.Length; i++)*/