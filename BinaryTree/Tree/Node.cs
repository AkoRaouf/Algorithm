using System;
using System.Collections.Generic;
using System.Text;

namespace TestAppForLeetCode.BinaryTree.Tree
{
    public class Node
    {
        public int Data;
        public Node left, right;

        public Node(int item)
        {
            Data = item;
            left = right = null;
        }
    }
}
