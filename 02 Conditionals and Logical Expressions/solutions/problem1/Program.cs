using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lecture_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            bool y = false;

            //string username = Console.ReadLine();
            //string password = Console.ReadLine();
            //if (username == "bob")
            //{
            //    if (password == "1234")
            //    {
            //        Console.WriteLine("True");    
            //    }
            //}
            //Console.WriteLine("Goodbye");


            //if (username == "bob" && password == "1234")
            //{
            //    Console.WriteLine("Welcome bob!");
            //}
            //else if (username == "tom" && password == "5678")
            //{
            //    Console.WriteLine("Welcome tom!");
            //}
            //else
            //{
            //    Console.WriteLine("Login Failed!");
            //}
            //Console.WriteLine("Goodbye");

           // bool b = false;

            //Console.WriteLine(username == "bob" && password == "1234");
            //int month_num = int.Parse(Console.ReadLine());
            //if (month_num == 1)
            //    Console.WriteLine("january");
            //else if (month_num == 2)
            //    Console.WriteLine("February");
            //else if (month_num == 3)
            //    Console.WriteLine("March");
            //else if (month_num == 4)
            //    Console.WriteLine("April");
            //else if (month_num == 5)
            //    Console.WriteLine("May");
            //else if (month_num == 6)
            //    Console.WriteLine("June");
            //else if (month_num == 7)
            //    Console.WriteLine("July");
            //else if (month_num == 8)
            //    Console.WriteLine("August");
            //else if (month_num == 9)
            //    Console.WriteLine("September");
            //else if (month_num == 10)
            //    Console.WriteLine("October");
            //else if (month_num == 11)
            //    Console.WriteLine("November");
            //else if (month_num == 12)
            //    Console.WriteLine("December");
            
            //int n = int.Parse(Console.ReadLine());
            //if (n%2==0)
            //{
            //    Console.WriteLine(n + " is Even");
            //}
            //else
            //{
            //    Console.WriteLine(n + " is Odd");
            //}

            double d = 100;
            Console.WriteLine(Math.Sqrt(d));
            //will print 10
            Console.WriteLine(Math.Pow(d/10,3));
            //will print 1000

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 &&  num2 > num3)
            {
                Console.WriteLine(num3 + ", " + num2 + ", " + num1);
            }
            else if (num1 > num3 && num3 > num2)
            {
                Console.WriteLine(num2 + ", " + num3 + ", " + num1);
            }
            else if (num2 > num1 && num1 > num3)
            {
                Console.WriteLine(num3 + ", " + num1 + ", " + num2);
            }
            else if (num2 > num3 && num3 > num1)
            {
                Console.WriteLine(num1 + ", " + num3 + ", " + num2);
            }
            else if (num3 > num1 && num1 > num2)
            {
                Console.WriteLine(num2 + ", " + num1 + ", " + num3);
            }
            else
            {
                Console.WriteLine(num1 + ", " + num2 + ", " + num3);
            }
        }
    }
}
