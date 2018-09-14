using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        int stepsTaken = 0;

        /// <summary>
        /// Calculates the depth of the tree according to the amount of nodes it stores.
        /// </summary>
        /// <param name="size">The amount of nodes the tree stores.</param>
        /// <returns></returns>
        public int TreeDepth(double size)
        {
            return (int)Math.Log(size, 2.0);
        }

        /// <summary>
        /// Inserts data into the tree.
        /// </summary>
        /// <param name="root">The root of the tree to insert to.</param>
        /// <param name="data">The data to insert.</param>
        /// <returns></returns>
        public Node Insert(Node root, int data)
        {
            // Check if current node exists.
            if (root == null)
            {
                // Creature new node if it doesn't exist.
                root = new Node();
                // Insert data.
                root.Data = data;
            }
            // If the data we want to insert is less than the current node, go left.
            else if (data < root.Data)
            {
                root.Left = Insert(root.Left, data);
            }
            // If the data we want to insert is greater than the current node, go right.
            else
            {
                root.Right = Insert(root.Right, data);
            }

            return root;
        }
        
        /// <summary>
        /// Finds a specific piece of data in the tree.
        /// </summary>
        /// <param name="root">The root of the tree to search through.</param>
        /// <param name="data">The data to search for.</param>
        /// <returns></returns>
        public Node Search(Node root, int data)
        {
            if (root == null)
            {
                Console.WriteLine("Could not find specified data in this tree.");
                stepsTaken = 0;
            }
            else if (data == root.Data)
            {
                Console.WriteLine($"Found specified data after {stepsTaken} steps.");
                stepsTaken = 0;
            }
            else if (data < root.Data)
            {
                stepsTaken++;
                Search(root.Left, data);
            }
            else
            {
                stepsTaken++;
                Search(root.Right, data);
            }

            return root;
        }

        // Debug method. Ignore.
        public void Traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.Data);
            Traverse(root.Left);
            Traverse(root.Right);
        }
    }
}
