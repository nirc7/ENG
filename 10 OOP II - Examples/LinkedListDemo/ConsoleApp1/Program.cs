using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node n1 = new Node(10);
            //Console.WriteLine(n1.value);
            //Node n2 = new Node(20);
            //n1.next = n2;
            //n2.next = new Node(30);
            //n1.next.next.next = new Node(40);



            LinkedList ll = new LinkedList(7);
            ll.PrintList();
            ll.InsertFirst(5);
            ll.PrintList();
            ll.InsertFirst(15);
            ll.PrintList();

            ll.InsertLast(25);
            ll.PrintList();
            ll.InsertLast(10);
            ll.PrintList();
            ll.InsertLast(40);
            ll.PrintList();

            Console.WriteLine(ll.Exists(15));
            Console.WriteLine(ll.Exists(5));
            Console.WriteLine(ll.Exists(25));
            Console.WriteLine(ll.Exists(155));


            ll.Remove(50);
            ll.PrintList();
            //ll.DeleteList();
            //ll.InsertLast(25);
            //ll.PrintList();

            ll.DeleteList();
            ll.AddSorted(8);
            ll.AddSorted(5);
            ll.AddSorted(2);
            ll.AddSorted(18);
            ll.AddSorted(10);
            ll.PrintList();

            //code...
        }
    }

    class Node
    {
        public int value;
        public Node next;

        public Node(int v)
        {
            value = v;
        }
    }

    class LinkedList
    {
        Node head;

        public LinkedList(int v)
        {
            head = new Node(v);
        }

        public bool Exists(int v)
        {
            for (Node temp = head; temp != null; temp = temp.next)
            {
                if (temp.value == v)
                {
                    return true;
                }
            }
            return false;
        }

        public void InsertAfter(Node temp, int value)
        {
            if (temp != null)
            {
                Node t = new Node(value);
                t.next = temp.next;
                temp.next = t;
            }
            else
            {
                Console.WriteLine("NULL- INSERT AFTER!");
            }
        }

        public Node FindNode(int v)
        {
            for (Node temp = head; temp != null; temp = temp.next)
            {
                if (temp.value == v)
                {
                    return temp;
                }
            }
            return null;
        }

        public void PrintList()
        {
            Console.WriteLine("LL:");
            for (Node temp = head; temp != null; temp = temp.next)
            {
                Console.Write(temp.value + " --> ");
            }
            Console.WriteLine(@"_/\_");
        }

        public void InsertLast(int v)
        {
            if (head == null)
            {
                InsertFirst(v);
                return;
            }

            Node temp = head;
            for (; temp.next != null; temp = temp.next) { }
            temp.next = new Node(v);
        }

        public void InsertFirst(int v)
        {
            Node newNode = new Node(v);
            newNode.next = head;
            head = newNode;
        }

        public void DeleteList() { head = null; }

        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.next;
            }
        }

        public void Remove(int value)
        {
            if (head == null)
            {
                return;
            }

            if (head.value == value)
            {
                RemoveFirst();
            }
            else
            {
                Node temp;
                for (temp = head; temp.next != null && temp.next.value != value; temp = temp.next) { }

                if (temp.next != null)
                {
                    temp.next = temp.next.next;
                }
            }
        }

        public void AddSorted(int value)
        {
            if (head == null)
            {
                head = new Node(value);
            }

            else if (value < head.value)
            {
                InsertFirst(value);
            }
            else
            {
                Node temp;
                for (temp = head; temp.next != null && temp.next.value < value; temp = temp.next) { }

                InsertAfter(temp, value);                
            }
        }
    }
}
