using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1
{
    class ArrayQueue
    {
        private int[] items;
        private int rear;
        private int front;
        private int count;
        public ArrayQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void Enqueue(int item)
        {
            if (count == items.Length)
                throw new Exception();
            items[rear] = item;
            rear = (rear + 1) % items.Length;
            count++;
        }

        public int Dequeue()
        {
           var item= items[front];
            items[front] = 0;
            front = (front + 1) % items.Length;
            count--;
            return item;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(items[i] + " ");
            }
            return stringBuilder.ToString();
        }
    }
}
