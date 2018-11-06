using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1_q2_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            AllPrimes(num);
            Console.WriteLine();
        }

        static void AllPrimes(int num)
        {
            for (int i = 2; i <= num; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + ", ");
                }
            }
        }

        static bool IsPrime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
