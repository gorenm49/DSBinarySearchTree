using System;
using System.Collections.Generic;

namespace DSBinarySearchTree
{
    public class BinarySearchTree
    {
        public Node root_node;
        public BinarySearchTree()
        {
            root_node = null;
        }
        public void InsertNode(int element)
        {
            if (root_node == null)
            {
                root_node = new Node(element);
                return;
            }
            InsertElement(root_node, new Node(element));
        }
        
        public void InsertElement(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }

            if (newNode.Element < root.Element)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    InsertElement(root.Left, newNode);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    InsertElement(root.Right, newNode);
                }
            }
        }
        
        public void Display(Node root)
        {
            if (root == null)
            {
                return;
            }

            Display(root.Left);
            System.Console.Write(root.Element + ", ");
            Display(root.Right);
        }
        
        public void Display()
        {
            System.Console.WriteLine("Elements Are:");
            Display(root_node);
        }

        public void Search(int element)
        {
            if (root_node == null)
            {   
                System.Console.WriteLine("Array is Empty.");
            }

            if (root_node.Equals(element))
            {
                System.Console.WriteLine("Match found");
            }

            if (root_node.CompareTo(element))
            {
                
                if (root.Right.Equals(element))
                {
                    System.Console.WriteLine("Match found");
                }               
            }

            if (root_node.CompareTo(element))
            {
                if (root.Left.Equals(element))
                {
                    System.Console.WriteLine("Match found");
                }
            }
        }
    }
}