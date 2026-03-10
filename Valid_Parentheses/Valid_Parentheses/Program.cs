using System.Collections.Generic;
using System;
namespace Valid_Parentheses
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine(solution.IsValid("()"));      
            Console.WriteLine(solution.IsValid("()[]{}"));  
            Console.WriteLine(solution.IsValid("(]"));      
            Console.WriteLine(solution.IsValid("([)]"));    
            Console.WriteLine(solution.IsValid("{[]}"));    
        }
        public class Solution {
            public bool IsValid(string s) {
                    Stack<char> stack = new Stack<char>();
                    foreach (char c in s)
                    {
                        if(c == '(' || c == '{' || c == '[')
                            stack.Push(c);
                        else
                        {
                            if(stack.Count == 0)
                                return false;
                           
                                char top = stack.Pop();
                                if ((c == ')' && top != '(') ||
                                    (c == ']' && top != '[') ||
                                    (c == '}' && top != '{'))
                                {
                                    return false;
                                }
                            
                        }
                        
                    }
                    return stack.Count == 0;
            }
        }
    }
}