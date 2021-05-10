using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1
{


    public class MinStack
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> minStack = new Stack<int>();

        public void push(int item)
        {
            stack.Push(item);

            if (minStack.Count==0)
                minStack.Push(item);
            else if (item < minStack.Peek())
                minStack.Push(item);
        }

        public int pop()
        {
            if (stack.Count == 0)
                throw new Exception();

            var top = stack.Pop();

            if (minStack.Peek() == top)
                minStack.Pop();

            return top;
        }

        public int min()
        {
            return minStack.Peek();
        }
    }
}
