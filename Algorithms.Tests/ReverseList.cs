using Algorithms.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class ReverseList
    {
        [Fact]
        public void Test()
        {
            var singleLinkedListNode = new SingleLinkedListNode(3);
            singleLinkedListNode.next = new SingleLinkedListNode(4);
            singleLinkedListNode.next.next = new SingleLinkedListNode(5);
            singleLinkedListNode.next.next.next = new SingleLinkedListNode(6);
            var functions = new LinkedListFunctions();
            List<int> res = new List<int>();
            functions.ReverseList(singleLinkedListNode, res);
            Assert.Equal(6, res.First());
            Assert.Equal(5, res.ElementAt(1));
            Assert.Equal(4, res.ElementAt(2));
            Assert.Equal(3, res.ElementAt(3));
        }
    }
}
