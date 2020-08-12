using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class StackFrom2Queues
    {
        [Fact]
        public void Test()
        {
            var s = new Algorithms.Library.StackFrom2Queues<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            var res = s.Pop();
            Assert.Equal(3, res);
            s.Push(4);
            s.Push(5);
            res = s.Pop();
            Assert.Equal(5, res);
            res = s.Pop();
            Assert.Equal(4, res);

        }
    }
}
