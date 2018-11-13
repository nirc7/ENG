using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            int num = 5;
            //opt1 -- preffred!
            bool isBigger = num >= 0;

            //opt2
            if (num >= 0)
            {
                isBigger = true;
            }

            bool isRaining = false;
            if (!isRaining)//b1 == false //b1 !=true
            {
                Console.WriteLine("in if");
                Console.WriteLine("not rainnig");
            }
            else
            {
                Console.WriteLine("rainnig");
            }

            Console.WriteLine("???");


            string name;
            name = "avo";
            if (name == "bob")
            {
                Console.WriteLine("hello bob!");
            }
            Console.WriteLine("bye");

            int number = 9;
            //int res = number % n;//  0 - (n-1)
            Console.WriteLine();
        }
    }
}
