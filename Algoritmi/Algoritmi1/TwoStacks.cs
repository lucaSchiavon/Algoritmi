using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1
{
    public class TwoStacks
    {
        private int top1;
        private int top2;
        private int[] items;

        public TwoStacks(int capacity)
        {
            if (capacity <= 0)
                throw new IndexOutOfRangeException("capacity must be 1 or greater.");

            items = new int[capacity];
            top1 = -1;
            top2 = capacity;
        }

        public void push1(int item)
        {
            if (isFull1())
                throw new IndexOutOfRangeException();

            items[++top1] = item;
        }

        public int pop1()
        {
            if (isEmpty1())
                throw new IndexOutOfRangeException();

            return items[top1--];
        }

        public bool isEmpty1()
        {
            return top1 == -1;
        }

        public bool isFull1()
        {
            return top1 + 1 == top2;
        }

        public void push2(int item)
        {
            if (isFull2())
                throw new IndexOutOfRangeException();

            items[--top2] = item;
        }

        public int pop2()
        {
            if (isEmpty2())
                throw new IndexOutOfRangeException();

            return items[top2++];
        }

        public bool isEmpty2()
        {
            return top2 == items.Length;
        }
        public bool isFull2()
        {
            return top2 - 1 == top1;
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < items.Length; i++)
                res += items[i];

            return res;
        }
       
    }
}
