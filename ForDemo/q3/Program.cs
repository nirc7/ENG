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
            Console.WriteLine("ENTER:");
            string input = Console.ReadLine();
            int count=0, sum = 0;

            for (; input != "done"; count++)
            {
                sum += int.Parse(input);

                Console.WriteLine("ENTER:");
                input = Console.ReadLine();
            }
            Console.WriteLine(sum*1.0 /count);
        }
    }
}
