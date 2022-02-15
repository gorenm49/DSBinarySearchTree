using System;

namespace DSBinarySearchTree
{
    public class Node
    {
        public int Element { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            this.Element = data;
        }
    }
}