using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class QueueFrom2Stacks
    {
        [Fact]
        public void Test()
        {
            var q = new Algorithms.Library.QueueFrom2Stacks<int>();
            q.Enqueue(42);
            q.Dequeue();
            q.Enqueue(14);
           var elm = q.Peek();
            Assert.Equal(14, elm);
            q.Enqueue(28);
            elm = q.Peek();
            Assert.Equal(14, elm);

            q.Enqueue(60);
            q.Enqueue(78);
            q.Dequeue();
            q.Dequeue();
        }
    }
}
