using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine CM1 = new CoffeeMachine();
            CM1.ShowDetails();
            Console.WriteLine("you get back: " + CM1.InsertCoins("1 Shekel", 5) + " Shekels");
            Console.WriteLine(CM1.ChangeOwner("Me"));
            CM1.ShowDetails();
            CM1.amountOfSugar= 7; //there was a leak in the sugar container:)
            Console.WriteLine("you get back: " + CM1.InsertCoins("1/2 Shekel", 7) + " Shekels");
            Console.WriteLine( CM1.ChangeOwner("Sivan"));
            Console.WriteLine("you get back: " + CM1.InsertCoins("2 Shekel", 4) + " Shekels");
            CM1.ShowDetails();
        }
    }

    class CoffeeMachine
    {
        //Members:
        private int CostOfCoffee=4;     //one cup of Coffe costs 4 Shekels
        //עלות לכוס אחת היא 4 שקלים
        private double amountOfMoney;
        public int amountOfSugar;
        public int amountOfCoffee;
        private string owner;   //the owner of the Coffee Machine
        //הבעלים של מכונת הקפה

        //Methods
        //the constructor will assigen 10 amounts of Coffee, 0 Shekls in the Machine, 20 amount of Sugar
        //and the owner will be the "fabric".
        //האיתחול יעשה ע"י השמה של 10 יחידות קפה, 0 שקלים במכונה, 20 יחידות של סוכר והבעלים יהיה
        //"fabric"
        public CoffeeMachine()
        {
            amountOfCoffee = 10;
            amountOfMoney = 0;
            amountOfSugar = 20;
            owner = "fabric";
        }

        /// <summary>
        /// To buy Coffee you have to insert coins of only one type ("1/2 Shekel", "1 Shekel" or 2 Shekel)
        /// If you have enough money you will get the Coffee and the change back, 
        /// while the machine will keeps the money for that Coffee (this money belongs to the owner). 
        /// If there is not enough money you will get it back.
        /// Note the console printing in the example!
        /// ניתן לקנות קפה ע"י סוג אחד של מטבעות בלבד. כאשר יש מספיק כסף ינתן קפה ויוחזר העודף
        /// הכסף של הקפה נישאר במכונה ושייף לבעלים של המכונה
        /// שים לב להדפסות על המסך ע"י הדוגמה
        /// </summary>
        /// <param name="type">"1/2 Shekel", "1 Shekel" or 2 Shekel</param>
        /// <param name="amount">how much coins</param>
        /// <returns>change for the buyer</returns>
        public double InsertCoins(string type, int amount)
        {
            double value = 0;
            switch(type)
            {
                case "1/2 Shekel":
                    value = 0.5;
                    break;
                case "1 Shekel":
                    value = 1;
                    break;
                case "2 Shekel":
                    value = 2;          
                    break;
                default:
                    Console.WriteLine("such a coin doe not exists!");
                    break;
            }
            value *= amount;
            if (value >= CostOfCoffee)
            {
                GiveOneCoffee();
                amountOfMoney += CostOfCoffee;
                return value - CostOfCoffee;
            }
            else
            {
                Console.WriteLine("Not enough Money!");
            }
            return value;
        }

        /// <summary>
        /// Will subtract the ingredients of one Coffee from the Machine supplies.
        /// One Coffee Cup will contain 1 Coffee amount and 2 Sugar amount.
        /// בהינתן הקפה צריך להוריד את כמות הרכיבים מהמכונה
        /// כוס קפה מכילה 1 יחידה של קפה ו2 יחידות של סוכר
        /// </summary>
        private void GiveOneCoffee()
        {
            amountOfCoffee -= 1;
            amountOfSugar -= 2;
            Console.WriteLine("One Coffee was given:)");
        }

        /// <summary>
        /// will change the owner to be a new one
        /// ישנה את הבעלים של המכונה
        /// </summary>
        /// <param name="newO">the new owner</param>
        /// <returns>see example</returns>
        public string ChangeOwner(string newO)
        {
            if (newO.Length > 2)
            {
                owner = newO;
                return "DONE!";
            }
            else
            {
                return "NOT DONE!";
            }

        }

        /// <summary>
        /// Will print the details of the machine to the screen, see the example for the exact format
        /// ידפיס את פרטי המכונה למסך
        /// </summary>
        public void ShowDetails()
        {
            Console.WriteLine("The Owner is: " + owner);
            Console.WriteLine("The Amount of Coffee left: " + amountOfCoffee);
            Console.WriteLine("The Amount of Sugar left: " + amountOfSugar);
            Console.WriteLine("The Owner earns: " + amountOfMoney);
        }
    }
}
