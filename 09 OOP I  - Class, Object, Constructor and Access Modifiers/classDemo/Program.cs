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
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            p1.id = 7;
            p1.name = "avi";
            p1.age = 20.5;

            Console.WriteLine(p1.id);
            Person p2 = new Person();
            p2.id = 8;
            p2.name = "benny";
            p2.age = 30;

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
        }
    }

    class Person
    {
        //Fields:
        public int id=9;//first
        public string name;
        public double age;

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
            id = i;
        }

        public void SayHello()
        {
            Console.WriteLine($"id={id} name={name} age={age}");
        }

        public void GetOldder(int year)
        {
            age += year;
        }
    }
}
