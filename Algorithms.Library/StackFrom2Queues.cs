using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Library
{
    public class StackFrom2Queues<T>
    {
        private  Queue<T> _queue = new Queue<T>();
        private  Queue<T> _queueBuffer = new Queue<T>();

        public void Push(T value)
        {
            _queueBuffer.Enqueue(value);
        }

        public T Peek()
        {
            if (!_queue.Any())
            {
                while (_queueBuffer.Count > 1)
                    _queue.Enqueue(_queueBuffer.Dequeue());
                var tmp = _queueBuffer;
                _queueBuffer = _queue;
                _queue = tmp;
            }
            return _queue.Peek();
        }

        public T Pop()
        {
            if (!_queue.Any())
            {
                while (_queueBuffer.Count > 1)
                    _queue.Enqueue(_queueBuffer.Dequeue());
                var tmp = _queueBuffer;
                _queueBuffer = _queue;
                _queue = tmp;
            }
            return _queue.Dequeue();
        }
    }
}
