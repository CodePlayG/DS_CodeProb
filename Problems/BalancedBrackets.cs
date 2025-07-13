using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class BalancedBrackets
    {
       static bool AreBracketsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    if (!IsMatchingPair(top, ch)) return false;
                }
            }

            return stack.Count == 0;
        }

        static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }

        //static void Main()
        //{
        //    Console.WriteLine("Enter a string with brackets:");
        //    string input = Console.ReadLine();

        //    bool result = AreBracketsBalanced(input);
        //    Console.WriteLine(result ? "✅ Balanced" : "❌ Not Balanced");
        //}
    }
}
//}
