using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "a v i cohen";
            Console.WriteLine(name.Length);
            string sub = name.Substring(6);
            Console.WriteLine(sub);
            string sub2 = name.Substring(2, 5);
            Console.WriteLine(sub2);
            char c = name[2];
            //name[2] = 'V';
            name = ChangeToUpper(name, 7);
            Console.WriteLine(name);           

        }

        static string ChangeToUpper(string name, int index)
        {
            name = name.Substring(0, index) + 
                    name[index].ToString().ToUpper()/*converted to string in order to use the ToUpper() function*/ +
                    name.Substring(index+1);
            return name;
        }
    }
}
