using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            //opt1
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{num} is prime!");
            }
            else
            {
                Console.WriteLine($"{num} is not prime!");
            }

            //opt1.2
            //bool isPrime = true;
            //for (int i = 2; i < Math.Sqrt(num); i++)
            //{
            //    if (num % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}
            //Console.WriteLine($"{num} is {(isPrime ? "" : "NOT")} prime!");


            //opt2
            //int i =2;
            //for (; i <= Math.Sqrt(num); i++)
            //{
            //    if (num % i == 0)
            //    {
            //        Console.WriteLine($"{num} is NOT prime!");
            //        break;
            //    }
            //}
            //if (Math.Sqrt(num) <  i )
            //{
            //    Console.WriteLine($"{num} is prime!");
            //}           
        }
    }
}

