using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1
{
    class LinkedList
    {
        private int size;
        private class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;


        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }
            size++;
        }
        //addLast
        public void AddLast(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
            size++;

        }

        public void DeleteFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException("il primo link è vuoto!");

            if (first == last)
            {
                first = last = null;
                size = 0;
                return;
            }

            var second = first.next;
            first.next = null;
            first = second;

            size--;
        }

        public void DeleteLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException("L'ultimo link è vuoto!");

            if (last == first)
            {
                last = first = null;
                size = 0;
                return;
            }

            Node previous = GetPrevious(last);
            previous.next = null;
            last = previous;
            size--;
        }

        public int Size()
        {
            return size;
        }

        public int[] ToArray()
        {
            if (size == 0)
                return null;

            int[] arr = new int[size];

            var current = first;
            int i = 0;
            while (current != null)
            {
                arr[i++] = current.value;
                current = current.next;

            }
            return arr;
        }

        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        public void Reverse()
        {
            var current = first.next;
            var previous = first;

            while (current != null)
            {
                var next = current.next;
                current.next = previous;

                previous = current;
                current = next;

            }

            last = first;
            last.next = null;
            first = previous;
        }


        public int GetKthFromTheEnd(int k)
        {
            if (IsEmpty())
                throw new Exception();
            
            var a = first;
            var b = first;

          

            for (int i = 0; i < k - 1; i++)
            {
                b = b.next;
                if (b == null)
                    throw new ArgumentOutOfRangeException();
            }
               

            while (b != last)
            {
                a = a.next;
                b = b.next;
            }
            return a.value;
        }

        private bool IsEmpty()
        {
            return first == null;
        }

        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == last)
                    return current;

                current = current.next;
            }
            return null;
        }

    }
}
