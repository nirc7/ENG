using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello5Times();

            //...code
            SayHello5Times();
            //code...
            SayHello5Times();

            int res = Return7();
            Console.WriteLine(res);
            Console.WriteLine(Return7() * 2);

            int sum = Add2Nums(2, 3);

            int r = Mul2Nums(res, sum);

            int num = 9;
            Console.WriteLine(num);//9
            AddOne(num);
            Console.WriteLine(num);//1 ERROR!!! 9

            num = AddOne(num);

            ForFuncDemo();

        }

        static void ForFuncDemo()
        {
           // int i = 0;
            int counter;

            for (int i = 0; i < 4; i++)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            //code...

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            //code....

            for (int i = 0; i < 7; i++)
            {
                Console.Write(i + ", ");
            }
        }

        static int AddOne(int num)
        {
            Console.WriteLine(num);//9
            num++;
            Console.WriteLine(num);//10
            return num;
        }

        /// <summary>
        /// multiply two number
        /// </summary>
        /// <param name="num1">the first number</param>
        /// <param name="num2">the second number</param>
        /// <returns>the multiplication</returns>
        static int Mul2Nums(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Add2Nums(int v1, int v2)
        {
            return v1 + v2;
        }

        static void SayHello5Times()
        {
            Console.WriteLine("hello avi");
            Console.WriteLine("hello avi");
            Console.WriteLine("hello avi");
            Console.WriteLine("hello avi");
            Console.WriteLine("hello avi");
        }

        static int Return7()
        {
            //code...
            int num = 7;
            return num;
        }

    }
}
