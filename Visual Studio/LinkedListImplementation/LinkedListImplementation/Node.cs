using System;
namespace LinkedListImplementation
{
    public class Node
    {
        // Data Part
        public int data { get; set; }
        public string name { get; set; }
        // Link part
        public Node next { set; get; }

        // Default constructor
        public Node()
        {
            name = "";
            data = 0;
            next = null;
        }

        public Node(int d, string nam){
            name = nam;
            data = d;
            next = null;
        }


    }
}
