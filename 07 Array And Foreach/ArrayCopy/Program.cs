using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 9, 2, 5, 4, 7, 3, 8, 1 };
            PrintArr(nums);

            int[] b = new int[nums.Length + 10];
            nums.CopyTo(b,5);//5 - where to start copying in b
            PrintArr(b);


            int[] c = new int[nums.Length + 10];
            Array.Copy(nums,c,4);//how much values to copy
            PrintArr(c);

            int[] d = new int[nums.Length + 10];
            Array.Copy(nums,2, d,3 , 4);
            PrintArr(d);

            int[] e = (int[])nums.Clone();//לשבט=לשכפל
            e[0] = 100;
            PrintArr(e);
            PrintArr(nums);

            Array.Sort(nums);
            PrintArr(nums);
            Array.Reverse(nums);
            PrintArr(nums);

            string[] names = new string[] { "charlie", "avi", "dora", "benny", "Da"};
            PrintArrStr(names);
            Array.Sort(names);
            PrintArrStr(names);


            double[] doubleArr = new double[] {1.2, 5.4, -8.7, 9.4 };
            Array.Sort(doubleArr);
        }

        static void PrintArrStr(string[] arr)
        {
            Console.Write("\nARRAY VALUES:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("\b\b ");
        }

        static void PrintArr(int[] arr)
        {
            Console.Write("\nARRAY VALUES:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("\b\b ");
        }
    }
}
