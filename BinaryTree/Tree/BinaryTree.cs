using System;
using System.Collections.Generic;
using System.Text;

namespace TestAppForLeetCode.BinaryTree.Tree
{
    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }

        public int Height(Node root)
        {
            if (root == null)
                return 0;
            else
            {
                int lheight = Height(root.left);
                int rheight = Height(root.right);

                if (lheight > rheight)
                    return (lheight + 1);
                else
                    return (rheight + 1);
            }
        }

        public void PrintGivenLevel(Node root, int level)
        {
            if (root == null)
                return;
            if (level == 1)
            {
                Console.Write(root.Data + " ");
            }
            else if (level > 1)
            {
                PrintGivenLevel(root.left, level - 1);
                PrintGivenLevel(root.right, level - 1);
            }
        }
    }
}
