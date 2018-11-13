using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            //opt1
            //if (num1 < num2 && num1 < num3)
            //{
            //    Console.WriteLine(num2 < num3 ?"n1 n2 n3": "n1 n3 n2" );
            //}
            //else if(num2 < num1 && num2 < num3)
            //{

            //}

            //opt2
            if (num1 < num2 && num2 < num3)//num1, num2, num3
            {
                Console.WriteLine($"{num1},{num2},{num3}");
            }
            else if (num1 < num3 && num3 < num2)//num1, num3, num2
            {
                Console.WriteLine($"{num1},{num3},{num2}");
            }
            else if (num2 < num1 && num1 < num3)
            {
                Console.WriteLine($"{num2},{num1},{num3}");
            }
            else if (num2 < num3 && num3 < num1)
            {
                Console.WriteLine($"{num2},{num3},{num1}");
            }
            else if (num3 < num1 && num1 < num2)
            {
                Console.WriteLine($"{num3},{num1},{num2}");
            }
            else //num3, num2, num1
            {
                Console.WriteLine($"{num3},{num2},{num1}");
            }

            //opt3
            //if (num1  < num2 && num2 < num3)
            //{
            //    if (true)
            //    {

            //    }
            //    else
            //    {

            //    }
            //}
            //else
            //{
            //    if (true)
            //    {

            //    }
            //}

            //opt4
            int temp;
            if (num2 < num1)
            {
                temp = num2;
                num2 = num1;
                num1 = temp;
            }//num1 < num2
            if (num3 < num2)
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }//num2 < num3
            if (num2 < num1)
            {
                temp = num2;
                num2 = num1;
                num1 = temp;
            }//num1 < num2
            Console.WriteLine($"{num1},{num2},{num3}");
        }
    }
}
