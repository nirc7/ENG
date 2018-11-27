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
            Queue q1 = new Queue();
            q1.PrintQueue();
            q1.Enqueue(1);
            q1.PrintQueue();
            q1.Enqueue(2);
            q1.PrintQueue();
            q1.Enqueue(3);
            q1.PrintQueue();
            q1.Enqueue(1);
            q1.PrintQueue();

            Console.WriteLine(q1.Dequeue());
            q1.PrintQueue();
            Console.WriteLine(q1.Dequeue());
            q1.PrintQueue();
            Console.WriteLine(q1.Dequeue());
            q1.PrintQueue();

            Console.WriteLine("\n\n\n");

            for (int i = 0; i < 10; i++)
            {
                q1.Enqueue(i);
                q1.PrintQueue();
            }

            Console.WriteLine("\n\n\n");

            for (int i = 0; i < 11; i++)
            {
                q1.Dequeue();
                q1.PrintQueue();
            }
        }
    }

    class Queue
    {
        int[] values = new int[10];
        int startPointer = 0;
        int endPointer = -1;

        public void Enqueue(int num)
        {
            if (!IsFull())
            {
                values[(++endPointer)%values.Length] = num;
            }
            else
            {
                Console.WriteLine("ERR ENQUEUE!");
            }            
        }

        public int Dequeue()
        {
            if (!IsEmpty())
            {
                return values[startPointer++ % values.Length];
            }
            else
            {
                Console.WriteLine("ERR DEQUEUE");
                return int.MinValue;
            }            
        }

        public bool IsEmpty()
        {
             return ValuesCount() == 0;
        }

        private int ValuesCount()
        {
            return endPointer - startPointer + 1;
        }

        public bool IsFull()
        {
            return ValuesCount() == values.Length;
        }

        public void PrintQueue()
        {
            Console.WriteLine("QUEUE:");
            for (int i = startPointer ; i <= endPointer; i++)
            {
                Console.Write(values[i%values.Length]   + ", ");
            }
            Console.WriteLine();
        }


    }
}
