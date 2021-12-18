using System;
namespace Linked_List
{
    public class SingleLinkedList
    {
		Node headNode;
        public SingleLinkedList()
        {
			headNode = null;
        }

		public bool CreateList(int value){
			headNode = new Node(value);
			if (headNode != null)
				return true;
			else
				return false;
		}
        
		public void AddFirst(int num)
        {
			Node newNode = new Node(num);
			if (headNode != null){
				newNode.next = headNode.next;
				headNode = newNode;
			}
			else{
				headNode = newNode;
			}
        }

		public void traverse(){
			Node temp = headNode;
			while(temp != null){
				Console.Write("\t{0}", temp.data);
				temp = temp.next;
			}
			Console.WriteLine("\nLinked List is Printed successfully...");
		}

		public void AddLast(int num)
        {
            Node newNode = new Node(num);
			Node temp = headNode;
			while (temp.next != null)
				temp = temp.next;
			temp.next = newNode;
        }

		public void InsertAfter(int num, int nodeNum){
			Node temp = headNode;
			while(temp != null){
				if (temp.data == nodeNum)
					break;
				temp = temp.next;
			}
			if(temp == null){
				AddLast(num);
			}else{
				Node newNode = new Node(num);
				newNode.next = temp.next;
				temp.next = newNode;
			}
		}

		public void InsertBefore(int num, int nodeNum)
        {
			Node temp = headNode, prev = headNode;
            while (temp != null)
            {
                if (temp.data == nodeNum)
                    break;
				prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                AddLast(num);
            }
            else
            {
                Node newNode = new Node(num);
                newNode.next = temp;
				prev.next = newNode;
            }
        }

		public void DeleteNode(int nodeNum)
        {
            Node temp = headNode, prev = headNode;
            while (temp != null)
            {
                if (temp.data == nodeNum)
                    break;
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
				Console.WriteLine(
					"Node {0} is not fouund in the List"
					,nodeNum);
            }
            else
            {
				prev.next = temp.next;
			}
        }
    }
}
