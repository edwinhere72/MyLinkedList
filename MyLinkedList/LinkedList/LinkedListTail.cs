using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList.LinkedList
{
    //This class will have the logic to connect the node objects to create
    //link list structure
   public class LinkedListTail
    {      
            //head indicate the satart of the node
            Node head = null;
            Node tail = null;
        public void AddLast(object data)
            {
                Node newItem = new Node();
                newItem.data = data;
                //Step 1: FirstItem
                //head --> newItem
                //tail --> new item
                if (head == null)
                {
                    head = newItem;                   
                    tail = newItem;
                }
                else
                {
                //Step 2 : SecondItem
                //current tails next item is set
                //to newItem. The current tail
                //is set to newItem
                tail.next = newItem;
                tail = newItem;
                }
            }

            public void AddFirst(object data)
            {
                Node newItem = new Node();
                newItem.data = data;
                if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
                else
            {
                newItem.next = head;               
                head = newItem;
            }
                
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

        public void DeleteLastNode()
        {
            if (head == null)
                return;
            if (head.next == null)
            {
                head = null;
                return;
            }

            Node p = head;
            while (p.next.next != null)
                p = p.next;
            p.next = null;
                
        }

        public void DeleteNode (object x)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty\n");
                return;
            }
            //Deletion of the first node 
            if (head.data == x)
            {
                head = head.next;
                return;
            }
            //Deletion in between or at the end
            Node p = head;
            while (p.next != null)
            {
                if (p.next.data == x)
                    break;
                p = p.next;
            }
            if (p.next == null)
                Console.WriteLine("Element " + x + " not in list");
            else
                p.next = p.next.next;
        }

        public void ReverseList()
        {
            Node prev, p, next;
            prev = null;
            p = head;
            while (p!= null)
            {
                next = p.next;
                p.next = prev;
                prev = p;
                p = next;
            }
            head = prev;


        }
     }
    }

