using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1.Esercizi
{
    class QueueReverser
    {
       // Queue<int> queue = new Queue<int>();
       // Stack<int> stack = new Stack<int>();
        public Queue<int> Reverse(Queue<int> queue, int k)
        {
            Stack<int> stack = new Stack<int>();
            //Stack<int> stack2 = new Stack<int>();
            for (int i=0; i<k;i++)
            stack.Push(queue.Dequeue());

            for (int i = 0; i < k ; i++)
                queue.Enqueue(stack.Pop());

            for (int i = 0; i < (queue.Count - k); i++)
                queue.Enqueue(queue.Dequeue());

            return queue;
        }
    }
}
