using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public interface IStack<T>
    {
        int GetSize();
        bool IsEmpty();
        void Push(T e);
        T Pop();
        T Peek();
    }
}
