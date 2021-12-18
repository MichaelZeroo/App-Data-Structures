using System;
namespace LinkedListImplementation
{
    public class LinkedList
    {
        public Node first;
        public Node last;

        public LinkedList()
        {
            first = null;
        }

        public bool createLinkedList(int d, string n){
            if (first == null)
            {
                Node new_node = new Node(d, n);
                first = new_node;
                if (first != null){
                    last = first;
                    return true;
                }
                else
                    return false;
            } else{
                Console.WriteLine("Linked List is already created");
                return false;
            }
        }

        public void addNode(int d, string n){
            if(first == null){
                createLinkedList(d, n);
            } else {
                Node node = new Node(d, n);
                // adding new node as first node
                node.next = first;
                first = node;
            }
        }

        public void addLastNode(int d, string n){
            if (first == null)
            {
                createLinkedList(d, n);
            }
            else
            {
                // Reference of the last node
                Node last_node = first;
                while(last_node.next != null){
                    last_node = last_node.next;
                }

                // New Node created
                Node node = new Node(d, n);

                // setting the next link of the current last node
                last.next = node;
                last = node;
                last_node.next = node;
            }
        }

        public void insertAfter(int d, string n, int num){
            if(first == null){
                createLinkedList(d, n);
            }else{
                Node temp = first;
                while(temp.data != num && temp != null){
                    temp = temp.next;
                }
                if(temp == null){
                    Console.WriteLine("Cannot insert. Not existed");
                }else{
                    Node node = new Node(d, n);
                    node.next = temp.next;
                    temp.next = node;
                }
            }
        }

        public void insertBefore(int d, string n, int num){
            if(first == null){
                createLinkedList(d, n);
            }else{
                Node temp = first, prev = first;
                while(temp != null){
                    if (temp.data == num)
                        break;
                    prev = temp;
                    temp = temp.next;
                }
                if(temp == null){
                    addLastNode(d, n);
                }else{
                    Node node = new Node(d, n);
                    node.next = temp;
                    prev.next = node;
                }
            }
        }

        public void printLinkedList(){
            Node node = first;
            while(node != null){
                Console.WriteLine("Num: " + node.data + "\tName: " + node.name);
                node = node.next;
            }
        }
    }
}
