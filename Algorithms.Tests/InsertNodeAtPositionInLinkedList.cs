using Algorithms.Library;
using Xunit;

namespace Algorithms.Tests
{
    public class InsertNodeAtPositionInLinkedList
    {
        [Fact]
        public void Test1()
        {   
            var llist = new SingleLinkedList();

            llist.InsertNode(16);
            llist.InsertNode(13);
            llist.InsertNode(7);
            var i = new Library.LinkedListFunctions();
            var head = i.InsertNodeAtPosition(llist.head, 1, 2);
            Assert.Equal(16, head.data);
            Assert.Equal(13, head.next.data);
            Assert.Equal(1, head.next.next.data);
            Assert.Equal(7, head.next.next.next.data);

        }
    }
}
