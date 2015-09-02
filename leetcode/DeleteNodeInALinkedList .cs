using System;
using System.Collections.Generic;

class Test
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    static void Main()
    {
        var list = new ListNode(0)
        {
            next = new ListNode(0)
            {
                next = new ListNode(1)
            }
        };
        var node = list.next.next;

        DeleteNode(list);

    }

    public static void DeleteNode(ListNode node)
    {
        if (node != null && node.next != null)
        {
            node.val = node.next.val;
            node.next = (node.next.next == null) ? null : node.next;
            DeleteNode(node.next);
        }
    }
}
