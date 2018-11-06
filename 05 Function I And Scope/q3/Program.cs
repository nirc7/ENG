using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                PrintMenu();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PrintNumberNice(Add(GetNumber(), GetNumber()));
                        break;
                    case 2:
                        PrintNumberNice(Sub(GetNumber(), GetNumber()));
                        break;
                    case 3:
                        PrintNumberNice(Mul(GetNumber(), GetNumber()));
                        break;
                    case 4:
                        PrintNumberNice(Div(GetNumber(), GetNumber()));
                        break;
                    case 5:
                        Console.WriteLine("bye");
                        return;
                    default:
                        Console.WriteLine("????");
                        break;
                }
                Console.WriteLine("PRESS ...");
                Console.ReadLine();
                Console.Clear();
            } while (true);

        }

        static void PrintNumberNice(double v)
        {
            Console.WriteLine("***** " + v + " *****");
        }

        static int GetNumber()
        {
            Console.Write("ENTER A NUMBER:");
            return int.Parse(Console.ReadLine());
        }

        static void PrintMenu()
        {
            Console.WriteLine(@"1-Add \ 2-Sub \ 3-Mul \ 4-Div \ 5 - Exit");
            Console.WriteLine("ENTER YOUR CHIOCE:");
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        static double Div(int num1, int num2)
        {
            return (double)num1 / num2;
        }
    }
}
