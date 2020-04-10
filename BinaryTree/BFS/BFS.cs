using System;
using System.Collections.Generic;
using System.Text;
using TestAppForLeetCode.BinaryTree.Tree;

namespace TestAppForLeetCode.BinaryTree.BFS
{
    public class BFS
    {
     
        public void printBFSOfTree()
        {
            Tree.BinaryTree tree = new Tree.BinaryTree
            {
                root = new Node(1)
            };
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Level order traversal " + "of binary tree is ");
            printLevelOrderQueue(tree);
        }

        public virtual void printLevelOrder(BinaryTree.Tree.BinaryTree binaryTree)
        {
            int h = binaryTree.Height(binaryTree.root);
            int i;
            for (i = 1; i <= h; i++)
            {
                binaryTree.PrintGivenLevel(binaryTree.root, i);
            }
        }

        public virtual void printLevelOrderQueue(BinaryTree.Tree.BinaryTree binaryTree)
        {
            binaryTree.PrintGivenLevel(binaryTree.root);
        }
    }
}
