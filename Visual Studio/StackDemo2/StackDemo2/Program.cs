using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();
            myStack.push();
            myStack.push();
            myStack.push();
            myStack.printStack();

            Console.ReadKey();
        }
    }
}
