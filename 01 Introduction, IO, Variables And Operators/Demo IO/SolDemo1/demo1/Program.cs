using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //OUTPUT
            Console.WriteLine(123);
            Console.WriteLine("hello world2!");
            Console.WriteLine("question");


            #region VARIABLES
            //variables
            int num;
            num = 7;
            Console.WriteLine(num);
            double avi = 7.8;
            Console.WriteLine(avi);
            bool b = true;
            b = false;
            Console.WriteLine(b);
            float f = 4.5f;
            Console.WriteLine(f);
            double d1 = 4.56789f;
            avi = 6.5f;
            string name = "avi";
            Console.WriteLine(name);
            char c = '@';
            Console.WriteLine(c);
            int num2 = 2 + 3;
            Console.WriteLine("name = " + name);
            Console.WriteLine(Math.Pow(2, 3));
            #endregion

            #region IO
            Console.WriteLine("\n\nPLEASE ENTER YOUR NAME:");
            string inputName =  Console.ReadLine();
            Console.WriteLine("SHALOM " + inputName);

            //dfsfdsfds
            /*sdfsfdf
             asdasd
             asdasd
             */

            Console.WriteLine("first line\nsecond line\tafter tab");

            Console.WriteLine("123\t1234567\t1");
            Console.WriteLine(@"123\t1234567\t1");
            Console.WriteLine("num2 = " + num2 + " name=" + name + ", d1=" + d1);
            Console.WriteLine("num2 = {0} name={1}, d1={2:F2}",num2,name, d1);
            Console.WriteLine($"num2 = {num2:F2} name={name}, d1={d1}");
            #endregion

            Console.WriteLine("1+2+3+4+\b = 10");


            Console.WriteLine("ENTER A NUJMBER:");
            string inputNum7 = Console.ReadLine();
            int num7 = int.Parse(inputNum7);
            num7 =num7*7;
            Console.WriteLine("number*7 = "  + num7);

            int num30 = int.Parse("30");

            int num8 = int.Parse(Console.ReadLine());
            Console.WriteLine( num8*2 );


            float f4 =  float.Parse("4.7");
            
        }
    }
}
