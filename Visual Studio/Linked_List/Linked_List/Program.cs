using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! of Linked List");
			testLinkedList();
            Console.ReadKey();
        }

		static void testLinkedList()
		{
			SingleLinkedList myList = new SingleLinkedList();
			string message = myList.CreateList(45) ? 
			                       "List Created Successfully":
			                       "List is not Created Successfully";
			Console.WriteLine(message);
			myList.traverse();
			myList.AddLast(23);
			myList.AddLast(42);
			myList.AddLast(76);
			myList.AddLast(86);
			myList.traverse();
			myList.InsertAfter(34, 76);
			myList.traverse();
			myList.InsertBefore(32, 34);
			myList.traverse();
			myList.DeleteNode(32);
			myList.traverse();
		}
    }
}
