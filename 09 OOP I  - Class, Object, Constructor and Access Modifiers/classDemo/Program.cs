using System;

namespace classDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ids = new int[30];
            string[] names = new string[30];
            double[] ages = new double[30];

            Person p1;
            p1 = new Person();
            int num = p1.id;
            Console.WriteLine(num);
            Console.WriteLine(p1.GetName());
            Console.WriteLine(p1.GetAge());
            p1.id = 7;
            p1.SetName ("avi");
            p1.SetAge(-20.5);

            Console.WriteLine(p1.id);
            Person p2 = new Person();
            p2.id = 8;
            p2.SetName( "benny");
            p2.SetAge( 30);

            p1 = p2;
            Console.WriteLine(p1.id);
            Console.WriteLine(p2.id);
            p1.SayHello();
            p2.SayHello();

            Person p3 = new Person();
            p3.SayHello();
            p3.id = 10;
            p3.SayHello();
            p3.GetOldder(2);
            p3.SayHello();
            p3.GetOldder(2);
            p3.SayHello();
            p2.SayHello();
            p3 = null;

            Person p4 = new Person(88);
            p4.SayHello();

            Person p5 = new Person(88, "charlie", 33.3);

            Person[] myClass;
            myClass = new Person[4];
            myClass[0] = new Person();
            myClass[1] = new Person(88);
            myClass[2] = new Person(77,"ana");
            myClass[3] = new Person(123,"sara", 70);

            myClass[0].id = 100;
            myClass[0].SayHello();

            Console.WriteLine("\n\nSAY HELLO:___________");
            for (int i = 0; i < myClass.Length; i++)
            {
                myClass[i].SayHello();
            }

            Console.WriteLine("\n\nSAY HELLO2:___________");
            foreach (var per in myClass)
            {
                per.SayHello();
            }
        }
    }

    class Person
    {
        //Fields:
        public int id=9;//first
        string name; //default private
        private double age;

        //Methods:
        public Person()//ctor tab>-tab //shortcut: constructor
        {
            name = "no name";
            age = 20;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                name = "shlishi";
            }
        }

        public Person(int i) // second
        {
            if (0 <= i)
            {
                id = i;
            }
            else
            {
                Console.WriteLine("ERR ID!");
            }            
        }

        public Person(int id, string name): this(id)
        {           
            SetName(name);
        }

        public Person(int id, string name, double age) : this(id, name)
        {
            SetAge(age);
        }

        public void SetName(string name)
        {
            if (2 < name.Length)
            {
                this.name = name;
            }            
        }

        public string GetName()
        { return name; }

        public void SayHello()
        {
            Console.WriteLine($"id={id} name={name} age={age}");
        }

        public void GetOldder(int year)
        {
            age += year;
        }

        public void SetAge(double a)
        {
            if (a < 20)
            {
                Console.WriteLine("ERR AGE!");
            }
            else
            {
                age = a;
            }            
        }

        public double GetAge()
        {
            Mul2Age();
            return  age;
        }

        private void Mul2Age()
        {
            age *= 2;
        }
    }
}
