using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=7, num2;
            FuncOut(out num,out num2 );
            Console.WriteLine(num);//9
            Console.WriteLine(num2);//10
        }

        static void FuncOut(out int num, out int num2)
        {
            num = int.Parse( Console.ReadLine());

            num++;//9
            num2 = 10;
        }
    }
}
