using System;

namespace PropDemo2
{
    public enum Course:byte {BIO, MATH, ENG=10, CS, REACT }//default int

    public class Person
    {
        int id;
        string name;
        static int counter = 10;
        const string SCHOOL = "Ruppin";
        Course myCourse = Course.REACT;

        public int Age { get; set; }

        public Person()
        {
            Id = 7;
            Name = "no";
            counter++;
        }

        public static int Counter
        {
            get { return counter - 10; }
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (0 < value && value <= 100)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("ERR ID!");
                }
            }
        }

        public string Name
        {
            get { return name + ":)"; }
            set
            {
                if (2 < value.Length)
                {
                    name = value;
                }
                else
                {
                    name = "errName";
                    Console.WriteLine("ERR NAME!");
                }
            }
        }

        public Course MyCourse
        {
            get { return myCourse; }
            set {
                if (Course.BIO <= value &&  value <= Course.REACT )
                {
                    myCourse = value;
                }
                else
                {
                    Console.WriteLine("ERR MYCOURSE");
                }
            }
        }

        public void Print() // instance (not static)
        {
            Console.WriteLine($"{Id},{Name},{Counter},{SCHOOL},{MyCourse}");
        }
    }
}