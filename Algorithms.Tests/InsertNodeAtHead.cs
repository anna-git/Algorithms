using Algorithms.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class InsertNodeAtHead
    {
        [Fact]
        public void Test1()
        {
            var inh = new Library.InsertNodeLinkedList();
            var list = new SingleLinkedList();

            var ints = new List<int> { 383, 484, 392, 975, 321 };
            foreach (var item in ints)
            {
                SingleLinkedListNode llist_head = inh.InsertNodeAtHead(list.head, item);
                list.head = llist_head;
            }
            Assert.Equal(321, list.head.data);
            Assert.Equal(975, list.head.next.data);
            Assert.Equal(392, list.head.next.next.data);
            Assert.Equal(484, list.head.next.next.next.data);
        }
    }
}
