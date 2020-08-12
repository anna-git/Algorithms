using System;
using System.Collections.Generic;

namespace Algorithms.Library
{
    /// <summary>
    ///https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
    /// </summary>
    public class LinkedListFunctions
    {
        public SingleLinkedListNode InsertNodeAtHead(SingleLinkedListNode llist, int data)
        {
            var item = new SingleLinkedListNode(data);
            if (llist == null)
            {
                llist = item;
            }
            else
            {
                var tmp = llist;
                llist = item;
                llist.next = tmp;
            }
            return llist;
        }
        public SingleLinkedListNode InsertNodeAtPosition(SingleLinkedListNode head, int data, int position)
        {
            var cursor = 0;
            var current = head;
            var previous = current;
            while (position != cursor)
            {
                cursor++;
                previous = current;
                current = current.next;

            }
            //handle 0 though
            previous.next = new SingleLinkedListNode(data);
            previous.next.next = current;
            return head;
        }
        public void ReverseList(SingleLinkedListNode head, IList<int> result)
        {
            if (result == null) result = new List<int>();
            if (head == null)
                return;

                ReverseList(head.next, result);
            result.Add(head.data);
        }
    }
}
