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
            BinaryTree.Tree.BinaryTree tree = new BinaryTree.Tree.BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Level order traversal " + "of binary tree is ");
            tree.PrintGivenLevel(tree.root, tree.Height(tree.root));
        }
    }
}
