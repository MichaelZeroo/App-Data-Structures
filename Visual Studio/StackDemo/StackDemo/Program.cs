using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("My stack");
            stack.Push(null);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push("Top of Stack");


            while(stack.Count != 0)
            {
                Console.WriteLine("Stack Value is {0}", stack.Pop());
            }
            Console.ReadKey();
        }
    }
}
