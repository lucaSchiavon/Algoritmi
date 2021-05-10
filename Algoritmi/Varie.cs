using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi
{
    public class Varie
    {

        List<char> leftBrackets = new List<char> { '(', '<', '[', '{' };
        List<char> rightBrackets = new List<char> { ')', '>', ']', '}' };

        #region "esercizi sulla struttura stack"
        public string reverse(string input)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in input)
            {
                stack.Push(c);
            }
            while (stack.Count > 0)
            {
                stringBuilder.Append(stack.Pop());
            }

            return stringBuilder.ToString();
        }

        public bool IsBalance(string input)
        {
            Stack<Char> stack = new Stack<Char>();
            List<char> lst = new List<char>();

            foreach (char ch in input)
            {
                if (IsLeftBracket(ch))
                    stack.Push(ch);

                if (IsRightBracket(ch))
                {
                    if (stack.Count == 0)
                        return false;
                    var top = stack.Pop();
                    if (BracketsMatch(top, ch)) return true;
                }
        
            }

            return stack.Count == 0;
        }

        private bool IsLeftBracket(char ch)
        {
            return leftBrackets.Contains(ch);
        }
        private bool IsRightBracket(char ch)
        {
            return rightBrackets.Contains(ch);
        }

        private bool BracketsMatch(char left, char right)
        {
            return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);
        }
        #endregion


    }
}
