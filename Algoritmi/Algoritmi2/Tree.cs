using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi2
{
    public class Tree
    {
        public class Node
        {
          
            public int Value;

            public Node(int value)
            {
                Value = value;
            }

            public Node LeftChild;
            public Node RightChild;
        }
        public Node root;

      

        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
                return;
            }
                

            Node current = root;
           
            while (current != null)
            {
               

                if (value > current.Value  )
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = newNode;
                        break;
                    }
                        current = current.RightChild;
                    
                }
                if (value < current.Value)
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = newNode;
                        break;
                    }
                        current = current.LeftChild;

                }
              
            }
        }
        public bool Find(int value)
        {
            var current = root;
            while (current != null)
            {
                if (value < current.Value)
                    current = current.LeftChild;
                else if (value > current.Value)
                    current = current.RightChild;
                else
                    return true;
            }
            return false;
        }
        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }
            public void TraversePreOrder(Node root)
        {
            //var root = node;
            if (root == null)
                return;

            Console.WriteLine(root.Value);
            //prima ricorsiva
            TraversePreOrder(root.LeftChild);
            //seconda ricorsiva
            TraversePreOrder(root.RightChild);
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }

        public void TraverseInOrder(Node root)
        {

            //var root = node;
            if (root == null)
                return;

            TraverseInOrder(root.LeftChild);
            Console.WriteLine(root.Value);
            TraverseInOrder(root.RightChild);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }

        public void TraversePostOrder(Node root)
        {

            //var root = node;
            if (root == null)
                return;

            TraversePostOrder(root.LeftChild);
            TraversePostOrder(root.RightChild);
            Console.WriteLine(root.Value);
           
        }
        public int Height()
        {
           return Height(root);
        }
        //private int _height;
        private int Height(Node root)
        {

            int heightLeft = 0;
            int heightRight = 0;

            if (root == null)
                return -1;

            if (IsLeaf(root))
                return 0;

           
            heightLeft =Height(root.LeftChild);
          
            heightRight = Height(root.RightChild);

            return 1 + Math.Max(heightLeft, heightRight);
        }

        public int Min()
        {
           return Min(root);
        }
        private int Min(Node root)
        {
            if (IsLeaf(root))
                return root.Value;

            var left = Min(root.LeftChild);
            var right = Min(root.RightChild);

          return  Math.Min(Math.Min(left, right), root.Value);
        }

        private bool IsLeaf(Node node)
        {
            return node.LeftChild == null && node.RightChild == null;
        }
    }
}
