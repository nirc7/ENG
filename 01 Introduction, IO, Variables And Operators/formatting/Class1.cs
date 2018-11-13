using System;

namespace formatting
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
			//markers
			Console.WriteLine("MARKERS");
			Console.WriteLine("the second marker is {1}, the first marker is {0}\n", 1,2);

			//alignment
			Console.WriteLine("the second marker is aligned to the right {1,10}, the first marker is aligned to the left {0,-10}.\n", 1,2);

			//Numbers
			Console.WriteLine("NUMBERS");

			//currency
			Console.WriteLine("100 dollars are:{0:C}\n", 100);

			//floating point
			Console.WriteLine("real number x.xx:{0:F2}\n ", 1.2345);

			//left and right zeros
			Console.WriteLine("minimum 3 numbers left of the point and exactely 4 to the right {0:000.0000}\n", 123456789.123456789);
			Console.WriteLine("minimum 3 numbers left of the point and exactely 4 to the right {0:000.0000}\n", 12.12);

			//with commas
			Console.WriteLine("123456789 with commas:{0:N}\n", 123456789);

			//exponential
			Console.WriteLine("123 as an exponential number:{0:E} \n",123);

			//hexadeciaml
			Console.WriteLine("the number 123 as hecxadecimal:{0:X}\n",123);
			Console.WriteLine("7 X (16^1) + 11*(16^0) = 123\n");

			//using @
            Console.WriteLine(@"this/ \n sentence  \t is \\ printed as is using @ sign.");

            Console.WriteLine(@"____________the \ char_______________________");
            //special characters

            // \n  = enter
            Console.WriteLine("line1\nline2");

            // \b one char back
            Console.WriteLine("123456\b7890");

            // \r goto line start 
            Console.WriteLine("1234567\r89");

            // \t one tab forward (8 chars)
            Console.WriteLine("12345\t6789");

            // \\ print the char \
            Console.WriteLine("123\\n45");

            // \" print the char "
            Console.WriteLine("123\"45");

            int a=7;
            Console.WriteLine(a+a + "asd"); //add two ints
            Console.WriteLine("asd" + a+ a); //concatenate two strings
            
			Console.ReadLine();
		}
	}
}
