using System;

namespace PrimeGenerator
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
			PrimeGenerator generator;
			generator = new PrimeGenerator();
			int prime = generator.NextPrime();
			Console.WriteLine("A prime : " + prime.ToString());
			generator.SetPosition(10);
			prime = generator.NextPrime();
			Console.WriteLine("A prime : " + prime.ToString());
			prime = generator.NextPrime();
			Console.WriteLine("A prime : " + prime.ToString());
			prime = generator.NextPrime();
			Console.WriteLine("A prime : " + prime.ToString());

		}
	}
}
