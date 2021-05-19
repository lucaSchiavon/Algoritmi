using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1
{
    class PriorityQueue
    {
        int[] items;
        int count;
      
        public PriorityQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void Add(int item)
        {
            if (IsFull())
                throw new Exception();

            
            int i = ShiftItemToInsert(item);

            items[i] = item;
            count++;
          
        }

        private int ShiftItemToInsert(int item)
        {
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (item < items[i])
                {
                    items[i + 1] = items[i];
                }
                else
                    break;
            }

            return i+1;
        }

        public int Remove()
        {
            if (IsEmpty())
                throw new Exception();

            return items[--count];
        }

        public bool IsFull()
        {
            return items.Length == count;
        }
        public bool IsEmpty()
        {
            return count==0;
        }


    }
}
