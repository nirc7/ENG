using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoomCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse( Console.ReadLine() );
            double length = double.Parse(Console.ReadLine());

            double primeter = (width + length) * 2;
            Console.WriteLine("the perimeter is : " + primeter);

            Console.WriteLine("the area is :" + (width*length)  );
        }
    }
}
