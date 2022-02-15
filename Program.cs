using System;

namespace DSBinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.InsertNode(56);
            tree.InsertNode(30);
            tree.InsertNode(70);

            tree.Display();

        }
    }
}