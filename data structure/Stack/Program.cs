using System;
using System.Collections.Generic;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用基础类中的stack类中的方法
            Console.WriteLine(MyStackValid("[]{}()"));
            Console.WriteLine(MyStackValid("{[()]}"));
            Console.WriteLine(MyStackValid("[{(]})"));
            Console.WriteLine(MyStackValid("[({})"));
            Console.ReadKey();
        }

        #region 使用基础类的Stack类的方法
        static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (c == ')' && stack.Pop() != '(')
                        return false;
                    if (c == '}' && stack.Pop() != '{')
                        return false;
                    if (c == ']' && stack.Pop() != '[')
                        return false;
                }
            }
            return stack.Count <= 0;
        }
        #endregion

        #region 测试自己的Stack类
        static bool MyStackValid(string s)
        {
            IStack<char> stack = new ArrayStack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (c == ')' && stack.Pop() != '(')
                        return false;
                    if (c == '}' && stack.Pop() != '{')
                        return false;
                    if (c == ']' && stack.Pop() != '[')
                        return false;
                }
            }
            return stack.GetSize() <= 0;
        }
        #endregion
    }
}
