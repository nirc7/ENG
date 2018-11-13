using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 9, 2, 5, 4, 7, 3, 8, 1 };

            foreach (var danny in nums)
            {
                //danny = 8;//read only!!!!
                Console.Write(danny*5 + ", ");
            }
            Console.WriteLine();

            string[] names = new string[] { "charlie", "avi", "dora", "benny", "Da" };
            foreach (var name in names)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();

           
        }
    }
}
