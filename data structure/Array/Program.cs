using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array<Person> arr = new Array<Person>();
            //int Id;
            //string Name;
            //int Age;
            //for (int i = 0; i < 10; i++)
            //{
            //    Id = i;
            //    Name = "a" + i;
            //    Age = i + 14;

            //    arr.AddLast(new Person { Id = Id, Name = Name, Age = Age });
            //}
            //arr.Add(1,new Person { Id = 10086, Name = "张三", Age = 15 });
            ////for (int i = 0; i < 10; i++)
            ////{
            ////    arr.AddLast(i);
            ////}
            //Person p1 = arr.Get(1);
            Array<int> arr = new Array<int>();
            for (int i = 0; i < 10; i++)
            {
                arr.AddLast(i);
            }
            Console.WriteLine(arr.ToString());
            arr.Add(1, 1234);
            arr.AddLast(123423);
            arr.AddLast(3434);
            Console.WriteLine(arr.ToString());
            arr.RemoceLast();
            arr.Remove(3);
            arr.RemoveElement(5);
            Console.WriteLine(arr.ToString());
            Console.ReadKey();
        }
    }
}
