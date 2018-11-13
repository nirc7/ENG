using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining varaiables.
            double x;
            double y;
            double z;
            string input1;
            string input2;

            //getting first number.
            Console.WriteLine("Please enter first number");
            input1 = Console.ReadLine();
            x = Double.Parse(input1);

            //getting seconed number.
            Console.WriteLine("Please enter seconed number");
            input2 = Console.ReadLine();
            y = Double.Parse(input2);

            //calculating.
            z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            //showing the result.
            Console.WriteLine("The result is:");
            Console.WriteLine("{0:f3}", z);
            Console.ReadLine();
        }
    }
}
