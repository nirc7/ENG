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
            int[] nums = new int[] { 3, 5, 7, 8, 11, 15, 18, 24, 25 };

            int index = BinarySearch(nums, 7);
            Console.WriteLine(index);

            foreach (var num in nums)
            {
                Console.WriteLine(  BinarySearch(nums, num));
            }

            Console.WriteLine(DateTime.Now.Millisecond);
            Random rnd = new Random(DateTime.Now.Millisecond);
            Console.WriteLine(rnd.Next(0,100));

            nums = new int[2000];
            for (int i = 0; i < 2000; i++)
            {
                nums[i] = i;
            }
            
            BinarySearch(nums, 80);

            Console.WriteLine(Math.Log(1024,2));

        }

        private static int BinarySearch(int[] nums, int valueToSearch)
        {
            int counter = 0;
            for (int start = 0, end = nums.Length - 1; start <= end;)
            {
                int middleIndex = (start + end) / 2;
                counter++;
                if (nums[middleIndex] == valueToSearch)
                {
                    Console.WriteLine("counter=" + counter);
                    return middleIndex;
                }
                else if (valueToSearch < nums[middleIndex])
                {
                    end = middleIndex - 1;
                }
                else
                {
                    start = middleIndex + 1;
                }
            }
            Console.WriteLine("counter"+ counter);
            return -1;
        }
    }


}
