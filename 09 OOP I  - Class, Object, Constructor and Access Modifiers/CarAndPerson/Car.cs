

using System;

namespace CarAndPerson
{
    class Car
    {
        //Fields:
        string model;
        int speed;
        double engine;
        bool isAutoGear;

        //Methods:
        public Car() : this("bmw", 250, 2.5, false)
        {
            model = "porsche";
        }

        public Car(string model, int s, double e, bool iAG)
        {
            this.model = model;
            SetSpeed(s);
            engine = e;
            SetGear(iAG);
        }

        public void SetGear(bool iAG)
        {
            isAutoGear = iAG;
        }

        public bool GetGear() { return isAutoGear; }

        public void SetSpeed(int s)
        {
            if (0 < s && s <= 300)
            {
                speed = s;
            }
            else
            {
                Console.WriteLine("ERR SEPEED");
                speed = 100;
            }
        }

        public int GetSpeed() { return speed; }

        public void Print()
        {
            Console.WriteLine($"{model},{speed},{engine},{isAutoGear}");
        }

    }
}