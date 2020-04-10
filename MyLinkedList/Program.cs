using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLinkedList.LinkedList;
using System.Collections;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // SimpleLinkedList lnk = new SimpleLinkedList();
            LinkedListTail lnk = new LinkedListTail();
           // LinkedListGenerics<int> lnk = new LinkedListGenerics<int>();
            lnk.AddLast(1);
            lnk.AddLast(2);
            lnk.AddLast(3);
            lnk.AddLast(4);
            lnk.AddFirst(0);
            lnk.ReadAll();
            lnk.DeleteLastNode();
            lnk.ReadAll();
            lnk.ReverseList();
            lnk.ReadAll();
            Console.ReadLine();

            int[] arg = new int [5];
            ArrayList grades = new ArrayList();
            List<int> test = new List<int>();
            //test.
        }
    }
}
