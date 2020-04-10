using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList.LinkedList
{
    //This class will have the logic to connect the node objects to create
    //link list structure
   public class LinkedListGenerics<AnyType>
    {      
            //head indicate the satart of the node
            Node<AnyType> head = null;
            Node<AnyType> tail = null;
        public void AddLast(AnyType data)
            {
                Node<AnyType> newItem = new Node<AnyType>();
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

            public void AddFirst(AnyType data)
            {
                Node<AnyType> newItem = new Node<AnyType>();
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
                Node<AnyType> current = head;
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

