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

            vec.Get(1);//5 <--

            vec.IsEmpty();//false


            vec.Size();// 7 <--
        }
    }

    class Vector
    {

    }
}
