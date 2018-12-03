using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropDemo2
{


    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Print();
            p1.Name = "avi";
            p1.Print();
            Console.WriteLine(Person.Counter);

            Course c1 = Course.CS;
            Console.WriteLine(c1);
            Console.WriteLine((int)c1);
            Console.WriteLine((int)c1+1);
            Console.WriteLine((Course)((byte)c1 + 1));
            Console.WriteLine(  (Course)((int)c1 + 4)   );

            Console.WriteLine((Course)1);

            p1.MyCourse = Course.BIO;
            p1.Print();

            Console.WriteLine();
            string[] courseNames = Enum.GetNames(typeof(Course));
            byte[] courseNums = (byte[])Enum.GetValues(typeof(Course));

            Console.WriteLine("choose one from the following list:");
            for (int i = 0; i < courseNames.Length; i++)
            { 
                Console.WriteLine( courseNums[i] + " - " +  courseNames[i]);
            }
            Console.WriteLine();
            string inputName =  Console.ReadLine();

            if (Enum.IsDefined(typeof(Course), inputName.ToUpper()))
            {
                p1.MyCourse  = (Course)Enum.Parse(typeof(Course), inputName,true);
            }
            p1.Print();

            int inputNum =  int.Parse(Console.ReadLine());
            p1.MyCourse = (Course)inputNum;
            p1.Print();
        }
    }

}
