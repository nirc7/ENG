using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciAndHanoiTower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Fibonacci(7));

            HanoiTower(3, 'A','B','C');
        }

        static void HanoiTower(int disks, char source, char dest, char temp)
        {
            if (disks==1)
            {
                Console.WriteLine(source +" --> "+ dest);
            }
            else
            {
                HanoiTower(disks-1, source, temp , dest);
                HanoiTower(1, source, dest, temp);
                HanoiTower(disks-1  , temp, dest, source);
            }
        }

        static int Fibonacci(int v)
        {
            if (v==1 || v==2)
            {
                return 1;
            }
            return Fibonacci(v-1) + Fibonacci(v-2);
        }
    }
}
