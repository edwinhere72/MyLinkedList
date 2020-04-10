using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList.LinkedList
{
    //This class will have the logic 
    //to connect the node objects to create
    //link list structure
    
    public class SimpleLinkedList
    {
        //start node of the linked list chain
        Node head = null;

        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                head.next = null;
            }
            else
            {
                Node current = head;
                // loop and find
                //the last node
                while (current.next != null)
                {
                    current = current.next;
                }
                //null this means this is the last element last node
                current.next= newItem;
                newItem.next = null;
            }
        }

        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            //this is now the first item
            //so the current head becomes the next item
            newItem.next = head;
            //this newitem become the head
            head = newItem;


        }
        public void ReadAll()
        {
            Node current = head;
            //loop until the last node
            //display the data
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;                
            }
            Console.WriteLine(current.data);           
        }
    }
}
