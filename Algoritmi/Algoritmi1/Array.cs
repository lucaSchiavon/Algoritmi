using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1
{
    class Array
    {
        private int[] arr;
        private int count;

        public Array(int lenght)
        {
            arr = new int[lenght];
        }
        public void Insert(int val)
        {
            ResizeIfRequired();
            arr[count++] = val;
        }

        public void RemoveAt(int index)
        {
            if (index >= count || index < 0)
                throw new ArgumentOutOfRangeException();

            for (int i = index; i < count; i++)
            {
                arr[i] = arr[i + 1];
            }
            count--;
        }
        public void InsertAt(int item, int index)
        {
            if (index >= count || index < 0)
                throw new ArgumentOutOfRangeException();
            
            ResizeIfRequired();

            for (int i = count-1 ; i > index; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[index] = item;
            count++;
        }

        public int IndexOf(int val)
        {
    
            for (int i = 0; i < count; i++)
            {
                if (arr[i] == val)
                return i;
            }

            return -1;
        }

        public int Max()
        {
            int max = 0;
           foreach(int item in  arr)
            {
               
                if (item > max)
                   max= item;
            }
            return max;

        }

        public Array Intersect(Array other)
        {
            var intersection = new Array(count);

            foreach (int item in arr)
            {
                if (other.IndexOf(item) >= 0)
                    intersection.Insert(item);
            }

            return intersection;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private void ResizeIfRequired()
        {
            if (arr.Length == count)
            {
                int[] newItems = new int[count * 2];
                for (int i = 0; i< count; i++)
                {
                    newItems[i] = arr[i];
                }
                arr = newItems;
            }
                
        }
        
    }
}
