using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(7);
            Console.WriteLine(n1.value);
            Console.WriteLine(n1.next==null);
            Node n2 = new Node(10);
            n1.next = n2;

            LinkedList list = new LinkedList(28);
            list.InsertLast(3); // second node in the list!
            list.InsertLast(10);
            list.InsertLast(4);
            list.InsertFirst(1);
            list.InsertAfter(list.FindNode(10),11 );

            //Console.WriteLine(list.Exists(4));

            //Node foundIt = list.FindNode(4);
            //if(foundIt != null)
            //    Console.WriteLine(foundIt.Value);
            //else
            //    Console.WriteLine("Not found!");

            list.PrintList();
            list.RemoveFirst();
            list.PrintList();

            list.Remove(10);
            list.PrintList();

            Console.WriteLine("*******************");
            LinkedList list2 = new LinkedList(8);
            list2.AddSorted(1);
            list2.AddSorted(10);
            list2.AddSorted(9);
            list2.AddSorted(19);
            
            list2.PrintList();

            list2.DeleteList();
            list2.AddSorted(1);

            list2.PrintList();
        }
    }
}
