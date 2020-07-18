using System;

namespace Algorithms.Library
{
    /// <summary>
    ///https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
    /// </summary>
    public class InsertANodeInLinkedList
    {

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

    }
}
