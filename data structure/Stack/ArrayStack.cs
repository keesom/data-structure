using Array;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    public class ArrayStack<T> : IStack<T>
    {
        Array<T> array;
        public ArrayStack(int capacity)
        {
            //创建一个数组
            array = new Array<T>(capacity);
        }
        public ArrayStack()
        {
            array = new Array<T>();
        }
        public int GetSize()
        {
            //获取数组的长度
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
        //看一眼栈顶的元素
        public T Peek()
        {
            return array.GetLast();
        }
        //从栈顶取出元素
        public T Pop()
        {
            return array.RemoceLast();
        }
        //添加一个元素
        public void Push(T e)
        {
            array.AddLast(e);
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Stack:");
            res.Append("[");
            for (int i = 0; i < array.GetSize(); i++)
            {
                res.Append(array.Get(i));
                if (i != array.GetSize() - 1)
                    res.Append(",");
            }
            res.Append("] top");
            return res.ToString();
        }
    }
}
