using System;

namespace DigitMul
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
			int num = 123456789;
			Console.WriteLine(DigitMul(num, 3));
            Console.WriteLine(DigitMul2(num, 3));
			 num = 234567890;
			Console.WriteLine(DigitMul(num, 3));
            Console.WriteLine(DigitMul2(num, 3));
			num = 123456789;
			Console.WriteLine(DigitMul(num, 10));
            Console.WriteLine(DigitMul2(num, 10));
			num = 12345607;
			Console.WriteLine(DigitMul(num, 3));
            Console.WriteLine(DigitMul2(num, 3));            
		}

        //sol1
        static int DigitMul(int num, int mul)
        {
            int newNum = 0;
            int n = 1;
            while (num > 0)
            {
                newNum += (((num%10)*mul)%10)*n;
                num /= 10;
                n *= 10;
            }
            return newNum;
        }
        //sol2
		static int DigitMul2(int num, int mul)
		{
			int temp=0, temp2=0;
			int num_temp = num;//holds the original number

			//to multiply the number with the second argument
			while( num>0)
			{
				temp *=10;
				temp += (((num%10)*mul)%10); //will hold the number after 
				//multiplication but un the reverse order
				num /=10;
			}

			//to reverse the number again
			while( num_temp>0)//go over the original number
			{
				temp2 *=10;					//the new number
				temp2 += temp%10;
				temp /=10;						//the reverse one
				num_temp /= 10;				//the original for the  '0' number like 1230
			}

			return temp2;
		}
	}
}
