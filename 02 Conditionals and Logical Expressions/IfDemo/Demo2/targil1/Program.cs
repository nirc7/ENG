using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLEASEE ENTER A NUIMBER:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"the number {num} is EVEN");
            }
            else
            {
                Console.WriteLine($"the number {num} is ODD");
            }

            //string puptut = (num % 2 == 0 ? "EVEN" : "ODD");
            Console.WriteLine($"the number {num} is " +   (num % 2 == 0 ? "EVEN" : "ODD") );

            
           
        }
    }
}
