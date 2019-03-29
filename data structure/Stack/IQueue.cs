using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    public interface IQueue<T>
    {

        int GetSize();
        bool IsEmpty();
        //在队列中添加元素
        void Enqueue(T t);
        //从队列中拿出元素
        T Dequeue();
        T GetFront();
    }
}
