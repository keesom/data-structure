using System;
using System.Collections;
using System.Text;

namespace Array
{
    public class Array<T>
    {
        private T[] data;
        private int size;
        public Array(int capacity)
        {
            data = new T[capacity];
            size = 0;
        }
        public Array() : this(10)
        {

        }
        //获得数组中的元素个数
        public int GetSize()
        {
            return size;
        }
        //获得数组容量
        public int GetCapacity()
        {
            return data.Length;
        }
        //判断数组是否为空
        public bool IsEmpty()
        {
            return size == 0;
        }
        //向所有元素后添加一个新元素
        public void AddLast(T e)
        {
            Add(size, e);
        }
        //给数组第一个元素赋值
        public void AddFirst(T e)
        {
            Add(0, e);
        }
        //在index个位置插入一个新元素
        public void Add(int index, T e)
        {
            if (index < 0 || index > size)
                throw new ArgumentException("index参数不合法");

            if (size == data.Length)
                Resize(2 * data.Length);
            for (int i = size - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = e;
            size++;
        }
        //删除数组中某个索引位置的元素，返回删除的元素
        public T Remove(int index)
        {
            if (index < 0 || index >= size)
                throw new ArgumentException("index参数不合法");
            T res = data[index];
            for (int i = index; i <= size; i++)
            {
                data[i] = data[i + 1];
            }
            size--;
            if (size == data.Length / 4 && data.Length / 2 >= 20)
                Resize(data.Length / 2);
            return res;
        }
        //删除第一个元素
        public T RemoveFirst()
        {
            return Remove(0);
        }
        //删除数组中最后一个元素
        public T RemoceLast()
        {
            return Remove(size - 1);
        }
        //取出索引为index的元素
        public T Get(int index)
        {
            if (index < 0 || index >= size)
                throw new ArgumentException("索引越界");
            return data[index];
        }
        //设置索引为index的值
        public void Set(int index,T e)
        {
            if (index <= 0 || index >= size)
                throw new ArgumentException("index参数不合法");
            data[index] = e;
        }
        //查询数组中是否存在某个数
        public bool Contains(T e)
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].Equals(e))//如果是一个对象则判断两个是否为同一个索引，如果是一个字符串对象则判断两个字符串是否相等
                    return true;
            }
            return false;
        }
        //查询某个数在数组中的索引位置（没有返回null）
        public int? Find(T e)
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].Equals(e))
                    return i;
            }
            return null;
        }
        //重写ToString方法
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Array: size = {0}, capacity = {1}\n", size, data.Length));
            res.Append('[');
            for (int i = 0; i < size; i++)
            {
                res.Append(data[i]);
                if (i != size - 1)
                {
                    res.Append(",");
                }
            }
            res.Append(']');
            return res.ToString();
        }
        //如果数组中有某个元素则删除,如果删除则返回true
        public bool RemoveElement(T e)
        {
            bool isRemove = false;
            for (int i = 0; i < size; i++)
            {
                if (data[i].Equals(e))
                {
                    Remove(i);
                    isRemove = true;
                }
            }
            return isRemove;
        }
        public T GetLast()
        {
            return Get(size - 1);
        }
        public T GetFirst()
        {
            return Get(0);
        }
        private void Resize(int newCapacity)
        {
            T[] newData = new T[newCapacity];
            for (int i = 0; i < size; i++)
            {
                newData[i] = data[i];
            }
            data = newData;
        }
    }
}
