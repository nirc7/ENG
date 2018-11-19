using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 7.26548654;
            Console.WriteLine("d={0:F2}, {1}", d, 3);
            string output = string.Format("d={0:F2}, {1}", d, 3) + "!";
            Console.WriteLine(output);


            Console.WriteLine("ENTER ...");
            int rows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, int.Parse(Console.ReadLine())];//[rows , columns]

            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix.GetLength(0));//2
            Console.WriteLine(matrix.GetLength(1));//3
            Console.WriteLine(matrix.Rank);//amount of dimensions

            PrintMatrix(matrix);
            InitMatrix(matrix);
            PrintMatrix(matrix);

            Console.WriteLine("FOREACH - START");
            int sum = 0;
            foreach (var num in matrix)
            {
                sum += num;
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.WriteLine("FOREACH - END");


            string[,] myClassNames = new string[2, 3]
                {
                    {"name1", "name2", "name3" },
                    {"name4", "name5",  "name7-1" }
                };
            PrintMatrix(myClassNames);


            Console.WriteLine("CUBE");

            int[,,] cube = new int[2, 3, 4];
            cube[0, 0, 0] = 100;
            cube[0, 0, 1] = 200;
            cube[2, 4, 1] = 99;

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        Console.WriteLine (cube[i, j, k] + "\t");
                    }
                }
            }


            Console.WriteLine();
        }

        static void PrintMatrix(string[,] matrix)
        {
            Console.WriteLine("\nPrint matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("\nPrint matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void InitMatrix(int[,] matrix)
        {
            int counter = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = counter++;
                }
            }
        }
    }
}
