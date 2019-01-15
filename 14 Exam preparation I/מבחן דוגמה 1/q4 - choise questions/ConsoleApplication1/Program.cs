using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            int x = 1;
            x = foo(y);
            Console.WriteLine(x);


            string s = "hello";
            for (int i = 0; i < 10; i++)
                s += s;
       
            int[] nums = new int[] { 1, 2, 3, 4 };
            func1(nums);
            foreach (int num in nums)
            {
                Console.Write(num + ",");
            }

            Console.WriteLine();

            int[] a = new int[]{1, 2, 3};
            int[] b= new int[a.Length+1];
            a.CopyTo(b,1);
            b[1] = 5;
            foreach (int num in a)
            {
                Console.Write(num + ",");
            }

        }

        static int foo(int x)
        {
            x = x + 1;
            return x;
        }



        static void func1(int[] a)
        {
            func2(a[1]);
        }
        static void func2(int a)
        {
            a = 7;
        }




    }
}
