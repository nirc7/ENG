using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
            //q4.1
            int[] arr = new int[] {2,3,5,1,4 };
            Console.WriteLine("START");
            foreach (int num in arr)
            {
                num++;
                Console.Write(num + ", " );
            }
            Console.WriteLine("END");
        }
    }
}
