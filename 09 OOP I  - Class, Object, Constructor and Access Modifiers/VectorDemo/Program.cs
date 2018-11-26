using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vec = new Vector();
            vec.IsEmpty();//true

            vec.Add(3);
            vec.Add(5);
            vec.Add(3);
            vec.Add(4);
            vec.Add(5);
            vec.Add(7000);
            vec.Add(8);
            vec.Add(90);
            vec.Add(10);

            vec.Get(1);//5 <--

            vec.IsEmpty();//false


            vec.Size();// 7 <--
            
            PrintVector(vec);
        }

        private static void PrintVector(Vector vec)
        {
            Console.WriteLine("VECTOR VALUES: ");
            for (int i = 0; i < vec.Size(); i++)
            {
                Console.Write(vec.Get(i) + ", ");
            }
        }
    }

    class Vector
    {
        //Fields:
        int[] intergers;
        int position;

        public Vector()
        {
            intergers = new int[1];
            position = -1;
        }

        public bool IsEmpty()
        {
            return position == -1;
        }

        public int Size()
        {
            return position + 1;
        }

        public int Get(int ind)
        {
            return intergers[ind];
        }

        public void Add(int v)
        {
            if (intergers.Length == position+1)
            {
                EnlargeVector();
            }
            intergers[++position] = v;
        }

        private void EnlargeVector()
        {
            Clone2(intergers.Length * 2);
        }

        private void Clone2(int amount)
        {
            int[] tempArr = new int[amount];
            intergers.CopyTo(tempArr, 0);
            intergers = tempArr;//!!!!
        }
    }
}
