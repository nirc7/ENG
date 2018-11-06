using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i%7 == 0 )
                {
                    Console.Write("BOOM\t");
                    continue;
                }
                Console.Write(i + "\t");
            }
        }
    }
}
