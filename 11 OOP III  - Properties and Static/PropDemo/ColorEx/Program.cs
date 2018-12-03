using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorEx
{
    enum Color : byte { WHITE, GREEN, YELLOW, RED, BLACK }

    class Program
    {
        static void Main(string[] args)
        {
            double d = 1.234567;
            Console.WriteLine($"{d:F2}");
            string a = "green";
            Console.WriteLine(ToCamelCase(a));

            //opt1
            byte[] nums = (byte[])Enum.GetValues(typeof(Color));
            string[] names = Enum.GetNames(typeof(Color));

            Console.WriteLine("CHOOSE ONE:");
            foreach (var num in nums)
            {
                Console.WriteLine(num + " - " + (Color)num);
            }
            string input = Console.ReadLine();

            if ('0' <= input[0] && input[0] <= '9')
            {
                int num = int.Parse(input);
                Console.WriteLine((Color)((num + 1) % nums.Length) +
                                   ",  " + (num + 1) % nums.Length);
            }
            else
            {
                if (Enum.IsDefined(typeof(Color), input.ToUpper()))
                {
                    Color c = (Color)Enum.Parse(typeof(Color), input, true);
                    Console.WriteLine((Color)((int)(c + 1) % nums.Length) +
                                                        ",  " + ((int)c + 1) % nums.Length);
                }
                else
                {
                    Console.WriteLine("no exists");
                }
            }

            //opt2
            //Console.WriteLine("CHOOSE ONE:");
            //foreach (var name in Enum.GetNames(typeof(Color)))
            //{
            //    Console.WriteLine(name);
            //}
        }

        private static string ToCamelCase(string a)
        {
            return a[0].ToString().ToUpper() + a.Substring(1).ToLower();
        }
    }
}
