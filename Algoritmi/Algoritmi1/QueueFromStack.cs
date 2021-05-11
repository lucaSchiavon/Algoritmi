using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1
{
    class QueueFromStack
    {
        //private readonly int[] items;
        //private int Rear;
        //private int Count;
        //private int Front;
        private StackWithInternalArray FirstStack = new StackWithInternalArray();
        private StackWithInternalArray SecondStack = new StackWithInternalArray();
        public QueueFromStack()
        {
            //items = new int[capacity];
        }
        //come implementare una coda mediante uno stack
        public void Enqueue(int item)
        {

            FirstStack.Push(item);

        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new OutOfMemoryException();

            MoveStack1ToStack2();

            return SecondStack.Pop();
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new OutOfMemoryException();

          
            MoveStack1ToStack2();

            return SecondStack.Peek();
        }

        public bool IsEmpty()
        {
            return FirstStack.IsEmpty() && SecondStack.IsEmpty();
        }

        private void MoveStack1ToStack2()
        {
            if (SecondStack.IsEmpty())
                while (!FirstStack.IsEmpty())
                {
                    SecondStack.Push(FirstStack.Pop());
                }
        }

    }
}
