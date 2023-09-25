using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    public class Queue_Using_LinkedList<T>
    {
        private LinkedList<T> linkedList = new LinkedList<T>();

        public void Enqueue(T data)
        {
            linkedList.AddLast(data);
        }

        public T Peek()
        {
            if (linkedList.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            return linkedList.First.Value;
        }

    }
}
