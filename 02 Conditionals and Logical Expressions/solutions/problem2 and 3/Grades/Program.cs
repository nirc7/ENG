using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the three grades");
            double math = double.Parse(Console.ReadLine());
            double eng= double.Parse(Console.ReadLine());
            double physics = double.Parse(Console.ReadLine());

            double avg =  (0.4*math) + (0.2*eng) + (0.4*physics) ;

            Console.WriteLine("average is:" + avg);

            
        }
    }
}
