using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Array_And_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            int[] nums2 = new int[] { 1, 2,77, 3 };
            nums[1] = 1;
            int[] nums3;

            Console.WriteLine("ENTER THE ARRAY SIZE:");
            nums3 = new int[int.Parse(Console.ReadLine())];
            //nums3 = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + ", ");
            }
            Console.WriteLine();


            int max = Max(nums2);
            Console.WriteLine(max);
            Console.WriteLine( nums2.Max());

            double[] monthelyGains = new double[] { -0.72, 1.05, 0.76, -1.49 };
            string[] symbols = new string[] { "MSFT", "INTC", "CSCO", "GOOG" };
            Console.WriteLine( MonthlyMax(monthelyGains, symbols));

    }

        static string MonthlyMax(double[] monthelyGains, string[] symbols)
        {
            return symbols[MaxIndex(monthelyGains)];
        }

        static int MaxIndex(double[] nums)
        {
            double num = nums[0];
            int index=0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (num < nums[i])
                {
                    num = nums[i];
                    index = i;
                }
            }
            return index;
        }

        static int Max(int[] nums)
        {
            int num=nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (num < nums[i] )
                {
                    num = nums[i];
                }
            }
            return num;
        }
    }
}
