using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = null;
            if (arr != null)
            {

            }
            else
            {
                arr = new int[4] { 1, 2, 3, 4 };
            }

            //arr = new int[8]; //created new array with 8 default values (zeros)

            int[] tempArr = new int[arr.Length + 4];
            for (int i = 0; i < arr.Length; i++)
            {
                tempArr[i] = arr[i];
            }
            arr = tempArr;
            tempArr = null;
            PrintArr(arr);
            arr= EnlargeArr(arr);
            PrintArr(arr);

            PrintArr(arr);
            EnlargeArrRef(ref arr);
            PrintArr(arr);

            BubbleSort(arr);
        }

        static void PrintArr(int[] arr)
        {
            Console.Write("\nARRAY VALUES:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("\b\b ");
        }

        //not working
        //static void EnlargeArr(int[] arr)
        //{
        //    int[] newArr = new int[arr.Length + 1];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        newArr[i] = arr[i];
        //    }
        //    arr = newArr;
        //    // return newArr;
        //}

        static void EnlargeArrRef( ref int[] arr)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
            // return newArr;
        }

        static int[] EnlargeArr(int[] arr)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            return newArr;
        }

        static void BubbleSort(int[] nums)
        {

        }
    }
}
