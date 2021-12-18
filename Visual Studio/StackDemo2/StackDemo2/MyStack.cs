using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo2
{
    public class MyStack
    {
        Stack stack;
        public MyStack()
        {
            this.stack = new Stack();
        }

        public void push()
        {
            int value;
            while (true)
            {
                Console.Write("Enter an Integer: ");
                String str_input = Console.ReadLine();

                if (Int32.TryParse(str_input, out value))
                {
                    stack.Push(value);
                    break;
                }
                else
                {
                    Console.WriteLine("Not an Integer Value.");
                }
            }
        }

        public int pop()
        {
            return (int)stack.Pop();
        }

        public void processStack()
        {
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        public void printStack()
        {

            for(int i = 0; i < stack.Count; i++)
            {
                Console.WriteLine(stack.ToArray()[i]);
            }
        }
    }

}
