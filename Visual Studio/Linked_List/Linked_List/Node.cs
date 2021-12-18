using System;
namespace Linked_List
{
    public class Node
    {
		public int data; // Data Part
		public Node next; // Link Part
        public Node()
        {
			next = null;
        }
		public Node(int n){
			data = n;
			next = null;
		}
    }
}
