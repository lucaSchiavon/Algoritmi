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
    }
}
