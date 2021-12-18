using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of Linked List!");
            LinkedList list = new LinkedList();

            if(list.createLinkedList(1, "Abbas"))
                Console.WriteLine("Linked List is created");
            else
                Console.WriteLine("Linked List is not created");

            if (list.createLinkedList(1, "Abbas"))
                Console.WriteLine("Linked List is created");
            else
                Console.WriteLine("Linked List is not created");

            list.addNode(2, "Cara");
            list.addLastNode(3, "Renzo");
            list.insertBefore(4, "Camacho", 3);
            list.insertAfter(5, "Daniel", 4);
            list.printLinkedList();
            Console.ReadKey();

        }
    }
}
