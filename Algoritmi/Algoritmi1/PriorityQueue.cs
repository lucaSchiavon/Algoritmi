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
            if (IsEmpty())
                throw new Exception();

            int i;
            for ( i = count-1; i >= 0; i--)
            {

                if (item < items[i])
                {
                    items[i + 1] = items[i];
                }
                else
                    break;

            }

            items[i+1] = item;
            count++;
          
        }

        public int Remove()
        {
            if (IsEmpty())
                throw new Exception();

            return items[--count];
        }

        public bool IsEmpty()
        {
            return items.Length == count;
        }

      
    }
}
