using System;

namespace Person
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Person p1 = new Person();
			Console.WriteLine( p1.ChangeName("ArikAndBentz") );
			Console.WriteLine();
			p1.PrintPerson();
			p1.Run();
			p1.Run();
			p1.Eat(3);
			p1.PrintPerson();
			p1.Run();
			p1.PrintPerson();
		}
	}
}
