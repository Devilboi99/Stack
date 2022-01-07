using System;
using System.Collections;
using stack;

namespace testing_my_steak
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new Stack<int>();
            name.Push(32); ;
            Console.WriteLine(name.Top());
            name.Pop();
            Console.WriteLine(name.Top());
            name.Push(14);
            name.Push(12);
            Console.WriteLine(name.Pop());
            Console.WriteLine(name.Size);
        }
    }
}