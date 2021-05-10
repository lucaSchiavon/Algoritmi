using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1
{
    class StackWithInternalLinkedList
    {
        //implementazione di uno stack con un array
        private readonly LinkedList items = new LinkedList();
      //  private int count;
        public void Push(int item)
        {
            items.AddLast(item);
           
        }
        public int Pop()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException();
            var lastValue = items.last.value;
            items.DeleteLast();
           return lastValue;
        }
        public int Peek()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException();
            return items.last.value;
        }
        public bool IsEmpty()
        {
            return items.Size()==0;
        }

        public override string ToString()
        {
            var current = items.first;
            StringBuilder stringBuilder = new StringBuilder(items.Size());

            while (current != null)
            {
                stringBuilder.Append(current.value);
                current = current.next;
            }

            return stringBuilder.ToString();
        }


    }
}
