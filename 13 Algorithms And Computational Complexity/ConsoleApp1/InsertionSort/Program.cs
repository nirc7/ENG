using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortNS
{
    class Program
    {
        static void Main(string[] args)
        {

            //swap XOR without temp
            int num1 = 7;
            int num2 = 5;
            num2 ^= num1;
            num1 = num2 ^ num1;
            num2 ^= num1;

            //swat +- without temp
            num1 = 5;
            num2 = 7;
            num1 -= num2;//num1 = 2
            num2 += num1;
            num1 = num2 - num1;


            int[] nums = new int[] { 3, 7, 2, 9, 1, 22, 5, 4 };
            InsertionSort(nums);

            Console.WriteLine();
            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        private static void InsertionSort(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    counter++;
                    if (nums[j] < nums[i])
                    {
                        //swap +- without temp
                        nums[j] -= nums[i];
                        nums[i] += nums[j];
                        nums[j] = nums[i] - nums[j];
                    }
                }
            }
            Console.WriteLine("counter= " + counter);
        }
    }
}
