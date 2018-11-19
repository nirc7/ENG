using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] cur = new double[,]
            {
                {3.544,  3.691,  3.623, 0},
                {4.73,   5.0823, 5.0059,0},
                {4.3551, 4.5272, 4.4113,0},
                {5.493,  5.9473, 5.8959,0}
            };
            string[] currNames = new string[] { "Dollar", "Euro", "Yen", "GBP" };

            Console.WriteLine(TableString(cur, currNames));
            AverageRows(cur);
            Console.WriteLine(TableString(cur, currNames));

            PrintArr(SumColumns(cur));
            Console.WriteLine();
            PrintArr(SumColumns2(cur));
        }

        static double[] SumColumns2(double[,] cur)
        {
            double[] sumArr = new double[cur.GetLength(1)];

            for (int j = 0; j < cur.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < cur.GetLength(0); i++)
                {
                    sum += cur[i, j];
                }
                sumArr[j] = sum;
            }
            return sumArr;
        }

        static void PrintArr(double[] v)
        {
            Console.WriteLine();
            foreach (var item in v)
            {
                Console.Write("{0:F2} , ", item );
            }
            Console.WriteLine("\b\b ");
        }

        static void AverageRows(double[,] curTable)
        {
            double sum = 0;
            for (int i = 0; i < curTable.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < curTable.GetLength(1) - 1; j++)
                {
                    sum += curTable[i, j];
                }
                curTable[i, curTable.GetLength(1) - 1] = sum / (curTable.GetLength(1) - 1);
            }
        }
        static string TableString(double[,] curTable, string[] names)
        {
            string output = "\nCurrency\tJan\tFeb\tMarch\tAvg\n";

            for (int i = 0; i < curTable.GetLength(0); i++)
            {
                output += names[i] + "\t\t";
                for (int j = 0; j < curTable.GetLength(1); j++)
                {
                    output += string.Format("{0:F2}", curTable[i, j]) + "\t";
                }
                output += "\n";
            }
            return output;
        }

        static double[] SumColumns(double[,] curTable)
        {
            double[] sumArr = new double[curTable.GetLength(1)];
            for (int i = 0; i < curTable.GetLength(0); i++)
            {
                for (int j = 0; j < curTable.GetLength(1); j++)
                {
                    sumArr[j] += curTable[i,j];
                }
            }
            return sumArr;
        }
    }
}
