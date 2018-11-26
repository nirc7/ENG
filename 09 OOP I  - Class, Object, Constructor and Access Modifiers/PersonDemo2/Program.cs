using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            //p1.id = 8;
            Console.WriteLine(p1.SayHello());
            p1.SetName("av");
            Console.WriteLine(p1.SayHello());
            p1.SetName("avi");
            Console.WriteLine(p1.SayHello());
            Console.WriteLine(p1.GetName());
            p1.SetId(7);
            Console.WriteLine(p1.SayHello());
            Person p2 = new Person(8, "be");
            Console.WriteLine(p2.SayHello());

            Person[] myClass = new Person[3];
            //myClass[0].SetId(5); //null Reference Exc!!!
            myClass[0] = new Person();
            myClass[1] = new Person(9);
            myClass[2] = new Person(12, "dora");

            PrintClass(myClass);

        }

        private static void PrintClass(Person[] myClass)
        {
            Console.WriteLine("MYCLASS:");
            foreach (Person per in myClass)
            {
                //per = new Person();//Read Only Variable!!!
                Console.WriteLine(per.SayHello());
            }
        }
    }

    class Person
    {
        //Fields:
        int id;//private
        string name;

        //Methods:
        public Person():this(1, "initName")
        {
            //SetId(1);
            //SetName("initName");

            //id = 1;
            //name = "initName";
        }

        public Person(int id):this(id, "initName"){}

        public Person(string name) : this(10, name) {}

        public Person(int id, string name)
        {
            SetId(id);
            SetName(name);
        }

        public string SayHello()
        {
            return $"my id is:{id}, my name is:{name}";
        }

        public void SetName(string n)
        {
            if (2 < n.Length )
            {
                name = n;
            }
            else
            {
                name = "err name";
                Console.WriteLine("ERR NAME!");
            }
            
        }

        public string GetName()
        {
            return name + ":)";
        }

        public void SetId(int id)
        {
            if (0 < id)
            {
                this.id = id;
            }
            else
            {

                Console.WriteLine("ERR ID!");
            }
        }
    }
}
