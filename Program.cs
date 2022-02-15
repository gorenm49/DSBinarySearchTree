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
            tree.InsertNode(22);
            tree.InsertNode(40);
            tree.InsertNode(60);
            tree.InsertNode(95);
            tree.InsertNode(11);
            tree.InsertNode(65);
            tree.InsertNode(3);
            tree.InsertNode(16);
            tree.InsertNode(63);
            tree.InsertNode(67);

            tree.Display();
        }
    }
}