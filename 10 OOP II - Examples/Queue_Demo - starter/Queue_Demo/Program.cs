using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Queue q2 = new Queue(3);
                q2.PrintQueue();
                q2.Enqueue(1);
                q2.Enqueue(2);
                q2.Enqueue(3);
                q2.Enqueue(4);
                q2.PrintQueue();
                //q2.Enqueue(2);
                //q2.PrintQueue();
                Console.WriteLine(q2.Dequeue());
                //q2.Enqueue(3);
                //q2.Enqueue(4);
                q2.PrintQueue();
                Console.WriteLine("____________________");
                Console.WriteLine(q2.Dequeue());
                Console.WriteLine(q2.Dequeue());
                q2.Enqueue(5);
                Console.WriteLine(q2.Dequeue());
                Console.WriteLine(q2.Dequeue());
            }
            
        }
    }

    class Queue
    {
        int[] arr;
        // Points to the empty cell
        int empty_cell = 0;

        // Default ctor - size 10!
        public Queue()
        {
           //code...
        }

        // Constructor that gets the size of the Queue
        public Queue(int size)
        {
            //code...
        }

        //add an element
        public void Enqueue(int value)
        {
            //code...
        }

        //remove an element
        public int Dequeue()
        {
            //code...
        }

        public bool IsEmpty()
        {
            //code...
        }

        public bool IsFull()
        {
            //code...
        }

        public void PrintQueue()
        {
            //code...
        }
    }
}
