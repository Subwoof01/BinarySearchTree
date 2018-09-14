using System;

namespace BinaryTree
{
    class BinarySearchTree
    {
        static void Main(string[] args)
        {
            Node root = null;
            Tree bst = new Tree();
            int size = 1000000;
            int[] randomData = new int[size];

            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                randomData[i] = random.Next(10000);
            }

            // For debugging purposes.
            randomData[72] = 512;

            for (int i = 0; i < size; i++)
            {
                root = bst.Insert(root, randomData[i]);
            }

            //bst.Traverse(root);
            Console.WriteLine(bst.TreeDepth(size));
            bst.Search(root, 512);
            Console.ReadKey();
        }
    }
}
