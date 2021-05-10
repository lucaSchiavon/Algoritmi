using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1
{
    class StackWithInternalArray
    {
        //implementazione di uno stack con un array
        private readonly int[] items = new int[5];
        private int count;
        public void Push(int item)
        {
            if (count == items.Length)
                throw new StackOverflowException();
            items[count++] = item;
        }
        public int Pop()
        {
            if (count == 0)
                throw new IndexOutOfRangeException();

            return items[--count];
        }
        public int Peek()
        {
            if (count == 0)
                throw new IndexOutOfRangeException();
            return items[count - 1];
        }
        public bool IsEmpty()
        {
            return count == 0;
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < count; i++)
                res += items[i];

            return res;

        }


    }
}
