//using System;
using Algoritmi.Algoritmi1;
namespace Algoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            //Array array = new Array(4);
            //array.Insert(10);
            //array.Insert(20);
            //array.Insert(30);
            //array.Insert(40);
            //array.InsertAt(5, 1);

            //LinkedList
            LinkedList linkedList = new LinkedList();
            linkedList.AddLast(3);
            var node = linkedList.last;
            linkedList.last.next = node;

            //linkedList.AddLast(12);
            //linkedList.AddLast(6);
            //linkedList.AddLast(9);
            //var node = linkedList.last;
            //linkedList.AddLast(8);
            //linkedList.AddLast(10);
            ////riferimento circolare
            //linkedList.last.next = node;

            linkedList.hasLoop();

            //
            int[] middleValues=linkedList.PrintMiddle();

            Varie varie = new Varie();
            //invertire una stringa con uno stack
            string stringaInvertita=varie.reverse("ciao");
            //bilanciare una stringa con uno stack
            //bool IsBalance = varie.IsBalance("(-8i)");

            //StackWithInternalArray stackWithInternalArray = new StackWithInternalArray();
            //stackWithInternalArray.Push(10);
            //stackWithInternalArray.Push(20);
            //stackWithInternalArray.Push(30);
            //int val1WithInternalArray = stackWithInternalArray.Pop();
            //string StampaStackWithInternalArray = stackWithInternalArray.ToString();
            //int val2WithInternalArray = stackWithInternalArray.Peek();


            //StackWithInternalLinkedList stackWithInternalLinkedList = new StackWithInternalLinkedList();
            //stackWithInternalLinkedList.Push(10);
            //stackWithInternalLinkedList.Push(20);
            //stackWithInternalLinkedList.Push(30);
            //int val1WithInternalLinkedList = stackWithInternalLinkedList.Pop();
            //string StampaStackWithInternalLinkedList = stackWithInternalLinkedList.ToString();
            //int val2WithInternalLinkedList = stackWithInternalLinkedList.Peek();


            //TwoStacks twoStacks = new TwoStacks(5);
            //twoStacks.push1(10);
            //twoStacks.push2(10);
            //twoStacks.push1(20);
            //twoStacks.push1(30);
            
            //twoStacks.push2(10);
            //twoStacks.push2(20);
            //twoStacks.push2(30);

            //twoStacks.pop1();
            //twoStacks.pop2();

            //MinStack minStack = new MinStack();
            //minStack.Push(2);
            //minStack.Push(4);
            //minStack.Push(3);
            //minStack.Push(1);
            //var min1 = minStack.Min();
            //minStack.Pop();
            //var min2 = minStack.Min();


            ArrayQueue arrayQueue = new ArrayQueue(5);

            arrayQueue.Enqueue(10);
            arrayQueue.Enqueue(20);
            arrayQueue.Enqueue(30);
            arrayQueue.Enqueue(40);
            //arrayQueue.Enqueue(50);
            arrayQueue.Dequeue();
            arrayQueue.Dequeue();
         
            arrayQueue.Enqueue(60);
            arrayQueue.Enqueue(70);

            PriorityQueue priorityQueue = new PriorityQueue(5);
            priorityQueue.Add(4);
            priorityQueue.Add(8);
            priorityQueue.Add(3);
            priorityQueue.Add(1);
            priorityQueue.Add(5);
            int val1 = priorityQueue.Remove();
            int val2 = priorityQueue.Remove();
            priorityQueue.Add(10);
            priorityQueue.Add(9);

        }


    }
}
