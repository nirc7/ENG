using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(20);
            tree.Left = new Node(10);
            tree.Right = new Node(5);
            tree.Right.Left = new Node(100);

            BinaryTree bt = new BinaryTree(50);
            //bt.head.Left = new Node(20);
            //bt.head.Left.Left = new Node(5);
            //bt.head.Left.Right = new Node(25);
            //bt.head.Right = new Node(70);

            bt.Add(20);
            bt.Add(5);
            bt.Add(25);
            bt.Add(70);
            bt.Add(80);
            bt.Add(55);
            bt.PrintTree();
            bt.Add(75);
            bt.PrintTree();
            Console.WriteLine(bt.GetMax());
            Console.WriteLine(bt.GetMax2());
            Console.WriteLine(bt.GetMin());

            //Console.WriteLine(bt.Find(17).Value);
            Console.WriteLine(bt.Find2(50).Value);

        }
    }

    class BinaryTree
    {
        Node head;

        public BinaryTree()
        {

        }

        public BinaryTree(int value)
        {
            head = new Node(value);
        }

        public bool IsEmpty() { return head == null; }

        public void PrintTree()
        {
            Console.WriteLine();
            Print(head);
            Console.WriteLine();
        }

        private void Print(Node node)
        {
            if (node.Left != null)
            {
                Print(node.Left);
            }
            Console.Write(node.Value + ", ");
            if (node.Right != null)
            {
                Print(node.Right);
            }
        }

        public void Add(int value)
        {
            if (IsEmpty())
            {
                head = new Node(value);
            }
            else
            {
                RecAdd(head, value);
            }
        }

        private void RecAdd(Node temp, int value)
        {
            if (value < temp.Value)
            {
                if (temp.Left == null)
                {
                    temp.Left = new Node(value);
                }
                else
                {
                    RecAdd(temp.Left, value);
                }
            }
            else
            {
                if (temp.Right == null)
                {
                    temp.Right = new Node(value);
                }
                else
                {
                    RecAdd(temp.Right, value);
                }
            }
        }

        public int GetMax2()
        {
            if (head == null)
            {
                return 0;
            }

            Node temp = head;
            for (; temp.Right != null; temp = temp.Right) { }
            return temp.Value;
        }

        public int GetMin()
        {
            if (head == null)
            {
                return 0;
            }

            Node temp = head;
            for (; temp.Left != null; temp = temp.Left) { }
            return temp.Value;
        }

        public int GetMax()
        {
            if (head == null)
            {
                return 0;
            }
            return GetMaxRec(head);
        }

        private int GetMaxRec(Node node)
        {
            if (node.Right == null)
            {
                return node.Value;
            }
            return GetMaxRec(node.Right);
        }

        public Node Find(int valueToFind)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Value == valueToFind)
                {
                    return temp;
                }
                else if (valueToFind < temp.Value)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            return null;
        }

        public Node Find2(int valueToFind)
        {
            return Find(head, valueToFind);
        }

        private Node Find(Node temp, int valueToFind)
        {
            if (temp != null)
            {
                if (temp.Value == valueToFind)
                {
                    return temp;
                }
                else if (valueToFind < temp.Value)
                {
                    return Find(temp.Left, valueToFind);
                }
                else
                {
                    return Find(temp.Right, valueToFind);
                }
            }
            return null;
        }
    }

    class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
