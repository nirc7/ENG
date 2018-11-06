using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "a v i cohen";
            Console.WriteLine(name.Length);
            string sub = name.Substring(2);
            Console.WriteLine(sub);
            string sub2 = name.Substring(2,5);
            Console.WriteLine(sub2);

        }
    }
}
