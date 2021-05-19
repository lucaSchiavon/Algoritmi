using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1.Esercizi
{
    public class QueueFromLinkedList
    {
        public class Node
        {
            public int Value;

            public Node(int value)
            {
                Value = value;
            }

            public Node Next;
          
        }

        public Node Head;
        public Node Tail;
        public int Count;
        public QueueFromLinkedList()
        {
            
        }

        public void Enqueue(int item)
        {
            //O(1)
            Node node = new Node(item);
            if (IsEmpty())
            {
                Head = Tail = node;
 
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            Count++;
        }
        public int Dequeue()
        {
            //O(1)
            if (IsEmpty())
                throw new IndexOutOfRangeException();

            int value;
            if (Head == Tail)
            {
                value = Head.Value;
                Head = Tail = null;
            }
            else
            {
                value = Head.Value;
                Node temp = Head.Next;
                Head.Next = null;
                Head = temp;
            }
            Count--;
            return value;
        }
        public int Peek()
        {
            //O(1)
            if (IsEmpty())
                throw new IndexOutOfRangeException();

            return Head.Value;
        }
        public int Size()
        {
           return Count;
        }
        public bool IsEmpty()
        {
            return Head == null;
        }

        public override string ToString()
        {
            Node current = Head;
            StringBuilder sb = new StringBuilder();
            while (current != null)
            {
                sb.Append(current.Value + " ");
                current = current.Next;
            }
            return sb.ToString();
        }
    }
}
