using System;
using System.Collections.Generic;

class Test
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    static void Main()
    {
        
    }

    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        Queue<TreeNode> pNodes = new Queue<TreeNode>();
        Queue<TreeNode> qNodes = new Queue<TreeNode>();

        pNodes.Enqueue(p);
        qNodes.Enqueue(q);

        while (pNodes.Count > 0 && qNodes.Count > 0)
        {
            var pNode = pNodes.Dequeue();
            var qNode = qNodes.Dequeue();

            if ((pNode == null || qNode == null) && pNode != qNode)
                return false;

            if (pNode != null && qNode != null)
            {
                if (pNode.val != qNode.val)
                    return false;

                pNodes.Enqueue(pNode.left);
                pNodes.Enqueue(pNode.right);
                qNodes.Enqueue(qNode.left);
                qNodes.Enqueue(qNode.right);
            }
        }

        if (pNodes.Count > 0 || qNodes.Count > 0)
            return false;

        return true;
    }
}
