using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
                Console.WriteLine(stack);
            }
            stack.Pop();
            Console.WriteLine(stack);
            Console.ReadKey();
        }
    }
}
