using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = CreateMatrix();
            PrintMat(mat);
        }

        private static void PrintMat(int[,] mat)
        {
            Console.WriteLine("\nMATRIX:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write( mat[i, j]+ "\t" );
                }
                Console.WriteLine();
            }
        }

        static int[,] CreateMatrix()
        {
            int[,] mat = new int[10, 10];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = (i + 1) * (j + 1);
                }
            }
            return mat;
        }
    }
}
