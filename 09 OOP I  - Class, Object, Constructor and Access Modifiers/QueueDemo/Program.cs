using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue(3);
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(1);

            q1.PrintQueue();
            Console.WriteLine( q1.Dequeue());
            q1.PrintQueue();
        }
    }

    class Queue
    {
        int[] arr;
        int emptyCell = 0;

        public Queue():this(5){}

        public Queue(int size)
        {
            arr= new int[size];
        }

        public void Enqueue(int num)
        {
            if (!IsFull())
            {
                arr[emptyCell++] = num;
            }
            else
            {
                Console.WriteLine("FULL!");
            }
        }

        public int Dequeue()
        {
            if (!IsEmpty())
            {
                int temp = arr[0];
                emptyCell--;
                for (int i = 0; i < emptyCell; i++)
                {
                    arr[i] = arr[i + 1];
                }

                return temp;
            }
            else
            {
                Console.WriteLine("EMNPTY!");
                return -1;
            }
        }

        public bool IsEmpty()
        {
            return emptyCell == 0;
        }

        public bool IsFull()
        {
            return emptyCell == arr.Length;
        }

        public void PrintQueue()
        {
            Console.WriteLine("QUEUE:");
            for (int i = 0; i < emptyCell; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
