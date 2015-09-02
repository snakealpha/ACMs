using System;
using System.Collections.Generic;

class Test
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    static void Main()
    {
        var node = new TreeNode(1)
        {
            left = new TreeNode(1)
            {
                left = new TreeNode(1)
            },
            right = new TreeNode(1)
            {
                left = new TreeNode(1),
                right = new TreeNode(1)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(1)
                }
            }
        };

        Console.WriteLine(MaxDepth(node));
    }

    public static int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        int leftDepth = 1;
        int rightDepth = 1;
        if (root.left != null)
            leftDepth = MaxDepth(root.left) + 1;
        if (root.right != null)
            rightDepth = MaxDepth(root.right) + 1;

        return Math.Max(leftDepth, rightDepth);
    }
}
