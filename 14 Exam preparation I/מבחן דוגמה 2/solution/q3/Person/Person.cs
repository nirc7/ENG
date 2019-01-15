using System;

namespace Person
{
	/// <summary>
	/// the class person will declare three members the person's name, his energy and 
	/// the path he had already run in his life.
	/// the person can eat some food portion and so gain energy.
	/// the person can run and burn the energy. every distance unit run will burn one portion
	/// of energy.
	/// a person with no energy (energy=0) is considered dead!
	/// </summary>
	public class Person
	{
		private int path;		//how much distance units the person run;
		private int energy;	//how many energy the person has = portions of food that the person eat.
		private string name; //the person's name

		/// <summary>
		/// this constructor will assign the name to be the enpty string,
		/// the path to zero and the enrgy to 1
		/// </summary>
		public Person()
		{
			path=0;
			energy=1;
			name = "";
		}

		/// <summary>
		/// every food portion will increase the persons energy by one.
		/// two portions will increase by two, and so on...
		/// </summary>
		/// <param name="portions"></param>
		public void Eat(int portions)
		{
			energy +=portions;
		}

		/// <summary>
		/// will return the information wheter the person has energy that is equal to zero
		/// that is considered dead.
		/// </summary>
		/// <returns>dead returns true, alive returns false </returns>
		private bool IsDead()
		{
			return energy==0;
		}

		/// <summary>
		/// will change the name of the person
		/// </summary>
		/// <param name="n1">the new name</param>
		/// <returns>the string "the new name is: X", where X in the new name. </returns>
		public string ChangeName(string n1)
		{
			name = n1;
			return "the new name is:" + name;
		}

		/// <summary>
		/// if the person is alive will run one distance unit and burn one food portion.
		/// if the person is dead will print to the console "can not run, person is dead!"
		/// 
		/// </summary>
		public void Run()
		{
			if(!IsDead())
			{
				path++;
				energy--;
			}
			else
				Console.WriteLine("can not run, person is dead!");
		}

		/// <summary>
		/// will print to the console the 3 members, each in a different line and 
		/// the name of the parameter
		/// </summary>
		public void PrintPerson()
		{
			Console.WriteLine("name:" + name);
			Console.WriteLine("energy:" + energy);
			Console.WriteLine("path:" + path);
		}


	}
}
