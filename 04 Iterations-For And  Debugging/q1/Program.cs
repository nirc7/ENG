using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER A NUMBER: ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 2; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine("fact =  " + fact);
        }
    }
}
