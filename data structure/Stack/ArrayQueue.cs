using Array;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private Array<T> array;
        public ArrayQueue(int capacity)
        {
            array = new Array<T>(8);
        }
        public ArrayQueue()
        {
            array = new Array<T>();//数组默认有10的容量
        }
        public T Dequeue()
        {
            return array.RemoveFirst();
        }

        public void Enqueue(T t)
        {
            array.AddLast(t);
        }

        public T GetFront()
        {
            return array.GetFirst();
        }

        public int GetSize()
        {
            return array.GetSize();
        }

        public bool IsEmpty()
        {
            return array.IsEmpty();
        }
        public int GetCapacity()
        {
            return array.GetCapacity();
        }
        
    }
}
