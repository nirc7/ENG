using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack(3);
            st.Push(100);
            st.Push(101);
            st.Push(102);
            st.Push(103);

            Console.WriteLine( st.Pop());
            Console.WriteLine(st.Peek());

            Console.WriteLine("WHILE");
            while (st.Peek() != int.MinValue)
            {
                Console.WriteLine(st.Pop());
            }

            Console.WriteLine("BYE");
        }
    }

    class Stack
    {
        int[] values;
        int pointer;

        public Stack():this(5){}

        public Stack(int size)
        {
            values = new int[size];
            pointer = 0;
        }

        public bool IsEmpty()
        {
            return pointer == 0;
        }

        public void Push(int num)
        {
            if (pointer == values.Length)
            {
                Console.WriteLine("push() - Full");
            }
            else
            {
                values[pointer++]  = num;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("pop() - EMPTY!");
                return int.MinValue;//-1
            }
            return values[--pointer];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("peek() - EMPTY!");
                return int.MinValue;//-1
            }
            return values[pointer-1];
        }
    }
}
