using System;

namespace rotateDigits
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
			int number = 36812;
			int newNumber;
			newNumber  = RotateDigits (number);
			Console.WriteLine(newNumber);

		}

		//שאלה 1 גירסה 1
		static int RotateDigits(int digits)
		{
			int NewNumber =0;
			int LSDigit;	//Least Segnificant Digit
			while(digits>9)
			{
				LSDigit = digits%10;
				digits = digits/10;	//delete the Least Segnificant Digit
				NewNumber = NewNumber*10+LSDigit; //the switched number
			}
			return NewNumber*10+digits;
		}

		//שאלה 1 גירסה 2
		static int RotateDigits2(int digits)
		{
			int NewNumber =0;

			while(digits>=1)
			{
				NewNumber = NewNumber * 10; //multipale the number
				NewNumber = NewNumber + digits%10; //add the new number
				digits = digits/10; //delete the Least Segnificant Digit
			}
			return NewNumber;
		}

	}
}
