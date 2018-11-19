using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[1, 1]
            {
                { 1 }
            };
            PrintBoard(mat);

            do
            {
                mat = PumpMatrix(mat);
                PrintBoard(mat);
                Console.WriteLine("ENTER...");

            } while (Console.ReadLine() == "y");
            Console.WriteLine("bye");
        }

        static void PrintBoard(int[,] matrix)
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

        static int[,] PumpMatrix(int[,] matrix)
        {
            int[,] newMat = new int[matrix.GetLength(0) + 1, matrix.GetLength(1) + 1];
            CopyMatrixValues(matrix, newMat);
            SumRows(newMat);
            SumColumns2(newMat);
            return newMat;
        }

        static void SumColumns2(int[,] cur)
        {
            for (int j = 0; j < cur.GetLength(1)-1; j++)
            {
                int sum = 0;
                for (int i = 0; i < cur.GetLength(0)-1; i++)
                {
                    sum += cur[i, j];
                }
                cur[cur.GetLength(0)-1,j] = sum;
            }            
        }

        static void SumRows(int[,] curTable)
        {
            int sum = 0;
            for (int i = 0; i < curTable.GetLength(0)-1; i++)
            {
                sum = 0;
                for (int j = 0; j < curTable.GetLength(1) - 1; j++)
                {
                    sum += curTable[i, j];
                }
                curTable[i, curTable.GetLength(1) - 1] = sum;
            }
        }

        static void CopyMatrixValues(int[,] sourceMatrix, int[,] destinationMatrix)
        {
            for (int i = 0; i < sourceMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < sourceMatrix.GetLength(1); j++)
                {
                    destinationMatrix[i, j] = sourceMatrix[i, j];
                }
            }
        }

    }
}
