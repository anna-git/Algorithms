using System.IO;

namespace Algorithms.Library
{
    public class SingleLinkedList
    {
        public SingleLinkedListNode head;
        public SingleLinkedListNode tail;

        public SingleLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SingleLinkedListNode node = new SingleLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
        static void PrintSingleLinkedList(SingleLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }

    }
}
