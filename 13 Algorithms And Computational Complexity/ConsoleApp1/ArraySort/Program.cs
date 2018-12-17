using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {3,7,8,4,1,9,5,14,2 };

            PrintArray(nums);
            Array.Sort(nums);
            Array.Reverse(nums);
            PrintArray(nums);

            string[] names = new string[]{"charlie", "Aai","avi" , "dora", "benny"};
            PrintArray(names);
            Array.Sort(names);
            PrintArray(names);

        }

        private static void PrintArray(string[] names)
        {
            Console.WriteLine();
            foreach (var num in names)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
        }

        private static void PrintArray(int[] nums)
        {
            Console.WriteLine();
            foreach (var num in nums)
            {
                Console.Write(num +", ");
            }
            Console.WriteLine();
        }
    }
}
