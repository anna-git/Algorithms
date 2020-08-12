using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Library
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/ctci-queue-using-two-stacks/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=stacks-queues
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueFrom2Stacks<T>
    {
        private readonly Stack<T> _stack = new Stack<T>();
        private readonly Stack<T> _stackBuffer = new Stack<T>();

        public void Enqueue(T value)
        {
            _stackBuffer.Push(value);
        }

        public T Peek()
        {
            if (!_stack.Any())
                while (_stackBuffer.Any())
                    _stack.Push(_stackBuffer.Pop());
            return _stack.Peek();
        }

        public T Dequeue()
        {
            if(!_stack.Any())
            while (_stackBuffer.Any())
                    _stack.Push(_stackBuffer.Pop());
            return _stack.Pop();
        }
    }
}
