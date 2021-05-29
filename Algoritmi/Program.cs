//using System;
using Algoritmi.Algoritmi1;
using Algoritmi.Algoritmi2;
using Algoritmi.Algoritmi2.Esercizi;
using System.Collections.Generic;

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


            //ArrayQueue arrayQueue = new ArrayQueue(5);

            //arrayQueue.Enqueue(10);
            //arrayQueue.Enqueue(20);
            //arrayQueue.Enqueue(30);
            //arrayQueue.Enqueue(40);
            ////arrayQueue.Enqueue(50);
            //arrayQueue.Dequeue();
            //arrayQueue.Dequeue();

            //arrayQueue.Enqueue(60);
            //arrayQueue.Enqueue(70);

            //PriorityQueue priorityQueue = new PriorityQueue(5);
            //priorityQueue.Add(4);
            //priorityQueue.Add(8);
            //priorityQueue.Add(3);
            //priorityQueue.Add(1);
            //priorityQueue.Add(5);
            //int val1 = priorityQueue.Remove();
            //int val2 = priorityQueue.Remove();
            //priorityQueue.Add(10);
            //priorityQueue.Add(9);

            //Algoritmi.Algoritmi1.Esercizi.QueueReverser queueReverser = new Algoritmi.Algoritmi1.Esercizi.QueueReverser();
            //Queue<int> queue =new  Queue<int>();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //queue.Enqueue(40);
            //queue.Enqueue(50);
            //queueReverser.Reverse(queue, 3);

            // Algoritmi.Algoritmi1.Esercizi.QueueFromLinkedList queueFromLinkedList = new Algoritmi1.Esercizi.QueueFromLinkedList();

            // queueFromLinkedList.Enqueue(10);
            // queueFromLinkedList.Enqueue(30);
            // queueFromLinkedList.Enqueue(8);
            // queueFromLinkedList.Enqueue(15);
            // int size = queueFromLinkedList.Size();
            //int val= queueFromLinkedList.Peek();
            // size = queueFromLinkedList.Size();
            // queueFromLinkedList.Dequeue();
            // queueFromLinkedList.Dequeue();
            // size = queueFromLinkedList.Size();
            // queueFromLinkedList.Enqueue(2);
            // queueFromLinkedList.Enqueue(4);


            //  Algoritmi.Algoritmi1.Esercizi.StackWithTwoQueues stackWithTwoQueues = new Algoritmi1.Esercizi.StackWithTwoQueues();
            //  stackWithTwoQueues.push(10);
            //  stackWithTwoQueues.push(20);
            //  stackWithTwoQueues.push(30);
            //int val=  stackWithTwoQueues.pop();
            // val = stackWithTwoQueues.pop();
            //   val = stackWithTwoQueues.pop();

            //Algoritmi.Algoritmi1.Esercizi.HashtableRepeatedChar hashtableRepeatedChar = new Algoritmi1.Esercizi.HashtableRepeatedChar();
            //char FirstNotRepeatedchar = hashtableRepeatedChar.GetFirstNotRepeatedChar("an appllee");
            //char FirstRepeatedchar = hashtableRepeatedChar.GetFirstRepeatedChar("n appllee");


            Fattoriale fattoriale = new Fattoriale();
            int fatt = fattoriale.Factorial2(5);

            Tree tree = new Tree();
            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(9);
            tree.Insert(1);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(10);
            tree.TraversePreOrder();
            //tree.TraverseInOrder();
            //tree.TraversePostOrder();
             int min= tree.Min();
           int height= tree.Height();
        }


    }
}
