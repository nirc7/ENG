using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStack_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(4);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Console.WriteLine("_________________________");
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(4);

            while (s.Peek() != -1)
            {
                Console.WriteLine(s.Pop());
            }

           
        }
    }
}
