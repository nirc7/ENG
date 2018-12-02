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
            Person p1 = new Person(2, "benny");
            p1.Print();
            p1.SetName("charlie");
            Console.WriteLine(p1.GetID());

            p1.SetID(18);
            p1.Id = 18; //Setter

            int res = p1.GetID();
            int res2 = p1.Id;//Getter
            Console.WriteLine(p1.Id);

            Console.WriteLine(p1.GetName());
            //p1.Grade = 100;
            Console.WriteLine(p1.Grade);
            p1.Address = "asdasdasd";
            //Console.WriteLine(p1.Address);
            Console.WriteLine(p1.Age);
        }
    }
    class Person
    {
        int id;
        string name;
        public int Grade
        {
            
            get
            {
                Console.WriteLine("asdasdsd");
                return Id;
            }
        }
        public int Age { get; }

        string address;

        public string Address
        {
            set
            {
                Console.WriteLine("asdasdsd");
                address = value;
            }
        }

        public Person(int i, string n)
        {
            id = i; name = n;
        }

        public int Id
        {
            set
            {
                if (0 < value)
                {
                    id = value;
                }
                else
                {
                    id = -7;
                    Console.WriteLine("ERR ID!");
                }
            }
            get { return id * 2; }
        }

        public void SetID(int i)
        {
            if (0 < i)
            {
                id = i;
            }
            else
            {
                id = -7;
                Console.WriteLine("ERR ID!");
            }
        }

        public int GetID() { return id * 2; }

        public void SetName(string n)
        {
            if (2 <= n.Length)
            {
                name = n;
            }
            else
            {
                name = "no name";
                Console.WriteLine("ERR NAME!");
            }
        }

        public string GetName() { return name + ":)"; }

        public void Print()
        {
            Console.WriteLine($"{Id},{name}");
        }
    }
}
