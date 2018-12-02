using System;

namespace StaticDemo
{
    public class Car
    {
        static int counter;
        public int LicensePlate { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Color myColor { get; set; }

        public Car()
        {
            counter++;
        }

        public static int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        public static void StaticChangeCounter10()
        {
            //Model = "kia"; // not STATIC!
            //Print();//NOT STATIC!
            counter += 10;
        }

        public void Print()
        {
            Console.WriteLine($"{LicensePlate},{Model},{counter}");

        }

        public void ChangeCounter(int v)
        {
            counter = v;
        }
    }
}