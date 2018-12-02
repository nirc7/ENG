using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
   public enum Color { RED, GREEN, YELLOW=8, WHITE, BLACK, SHAHOR = BLACK}

    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[] 
            {
                "red", "green", "yellow", "white", "black"
            };

            if (args.Length == 2)
            {
                Console.WriteLine("args[0] = " + args[0]);
                Console.WriteLine("args[1] = " + args[1]);
            }
            

            Car c = new Car();
            c.Model = "BMW";
            Car.Counter = 7;
            //Car.licensePlate
            c.Print();

            Car c2 = new Car();
            c2.Print();
            c2.ChangeCounter(5);
            c2.Print();
            Car.StaticChangeCounter10();
            c2.Print();

            Console.WriteLine();
            Math.Pow(2,3);
            Console.WriteLine(Math.PI);
            Console.WriteLine( (Math.PI).ToString().Substring(Math.PI.ToString().IndexOf(".")+1).Length  );

            //Stam();

            Car c3 = new Car();
            c3.Color = "red";
            Console.WriteLine(c3.Color);//string color

            if (c3.Color == "rad")
            {
                Console.WriteLine("sport car!");
            }


            Car c4 = new Car();
            c4.Color = colors[0];
            Console.WriteLine(c4.Color);//string color

            if (c4.Color == colors[0])
            {
                Console.WriteLine("sport car!");
            }


            Car c5 = new Car();
            c5.myColor = Color.RED;

            if (c5.myColor == Color.RED)
            {
                Console.WriteLine("SPORT CAR!");
            }

            Console.WriteLine(c5.myColor);
            Console.WriteLine((int)c5.myColor);
            Console.WriteLine((int)c5.myColor + 1);
            Console.WriteLine((Color)((int)c5.myColor + 1));

            switch (c5.myColor)
            {
                case Color.RED:
                    break;
                case Color.GREEN:
                    break;
                case Color.YELLOW:
                    break;
                case Color.WHITE:
                    break;
                case Color.BLACK:
                    break;
                default:
                    break;
            }
        }

        public void Stam() {

        }
    }
}
