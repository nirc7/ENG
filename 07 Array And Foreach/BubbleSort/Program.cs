using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 9,2,5,4,7,3,8,1};
            PrintArr(nums);
            BubbleSort(nums);
            PrintArr(nums);
        }

        static void BubbleSort(int[] nums)
        {
            int temp, counter=0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length-1-i; j++)
                {
                    counter++;
                    if (nums[j+1] < nums[j] )
                    {
                        //swap
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(counter);
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
