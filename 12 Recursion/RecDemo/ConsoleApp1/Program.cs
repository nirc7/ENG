using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            f1_2(5);
            Console.WriteLine();
            Console.WriteLine( f2_2(1234));
            Console.WriteLine();
            f3_2(5);
            Console.WriteLine();
            f4_2(5);
            Console.WriteLine();

            f5_2(2,5);
            Console.WriteLine();
            f5_2(5, 2);
            Console.WriteLine();

            Console.WriteLine( "="+ f7_2(2, 5));
            Console.WriteLine();
            Console.WriteLine( "=" + f7_2(5, 2));
            Console.WriteLine();
        }

        private static int f7_2(int v1, int v2)
        {
            if (v2 < v1) //inverse the values - will run only once!
            {
                return f7_2(v2, v1);
            }
            else
            {
                if (v1 == v2)//stop condition
                {
                    Console.Write(v1);
                    return v1;
                }
                else //rec step
                {
                    Console.Write(v1 + "+");
                    return v1 + f7_2(v1 + 1, v2);
                }
            }
        }

        private static void f5_2(int v1, int v2)
        {
            if (v2 < v1) //inverse the values - will run only once!
            {
                f5_2(v2,v1);
            }
            else
            {
                if (v1==v2)//stop condition
                {
                    Console.Write(v1);
                }
                else //rec step
                {
                    Console.Write(v1 + "+");
                    f5_2(v1 + 1, v2);
                }                
            }
        }

        private static int f7(int v1, int v2)
        {
            if (v2 < v1)
            {
                return f7(v2, v1);
            }
            else
            {
                if (v1 == v2)
                {
                    Console.Write(v1);
                    return v1;
                }
                else
                {
                    Console.Write(v1 + "+");
                    return v1 + f7(v1 + 1, v2);
                }
            }
        }

        private static void f5(int v1, int v2)
        {
            if (v2<v1)
            {
                f5_2(v2,v1);
            }
            else
            {
                if (v1==v2)
                {
                    Console.Write(v1);
                }
                else
                {
                    Console.Write(v1 + "+");
                    f5_2(v1 + 1, v2);
                }                
            }
        }

        static void f4_2(int n)
        {
            if (0 < n)
            {
                f4_2(n - 1);
                Console.Write(n);                
            }
        }

        static void f3_2(int n)
        {
            if (0 < n )
            {
                Console.Write(n);
                f3_2(n-1);
            }
        }

        static int f2_2(int n)
        {
            if (n < 10)
            {
                return n;
            }
            return n%10 + f2_2(n/10);
        }

        static void f1_2(int n)
        {
            if (0 < n)
            {
                Console.Write("*");
                f1_2(n-1);
            }
        }

        private static void f4(int v)
        {
            if (v > 0)
            {
                f4(v - 1);
                Console.Write(v);              
            }
        }

        private static void f3(int v)
        {
            if (v>0)
            {
                Console.Write(v);
                f3(v - 1);
            }            
        }

        private static int f2(int v)
        {
            if ( v < 10)
            {
                return v;
            }
            return v % 10 + f2(v / 10);
        }

        private static void f1(int v)
        {
            if (v!=0)
            {
                Console.Write("*");
                f1(v - 1);
            }            
        }
    }
}
