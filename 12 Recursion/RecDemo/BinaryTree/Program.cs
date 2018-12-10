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
            bt.head.Left = new Node(20);
            bt.head.Left.Left = new Node(5);
            bt.head.Left.Right = new Node(25);
            bt.head.Right = new Node(70);
            bt.PrintTree();

        }
    }

    class BinaryTree
    {
        public Node head;


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
