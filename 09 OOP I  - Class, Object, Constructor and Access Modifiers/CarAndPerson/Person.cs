using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAndPerson
{
    class Person
    {
        string name;
        int age;
        Car myCar;

        public Person() : this("avi", 30, new Car()) { }

        public Person(string name, int age, Car myCar)
        {
            this.name = name;
            this.age = age;
            this.myCar = myCar;
        }

        public void SetCar(Car c)
        {
            myCar = c;
        }

        public Car GetCar()
        {
            Car temp = myCar;
            myCar = null;
            return temp;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.Write($"{name},{ age} -- ");
            if (myCar != null)
            {
                myCar.Print();
            }
            else
            {
                Console.WriteLine(" no CAR ):");
            }

            Console.WriteLine();
        }
    }
}
