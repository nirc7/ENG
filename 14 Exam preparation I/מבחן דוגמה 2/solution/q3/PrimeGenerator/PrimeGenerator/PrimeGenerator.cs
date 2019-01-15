using System;

namespace PrimeGenerator
{
	/// <summary>
	/// Summary description for PrimeGenerator.
	/// </summary>
	public class PrimeGenerator
	{
		//dim var
		//private int Generator;
		int Position;

		//constructor
		public PrimeGenerator()
		{
			//Generator = new int();
			SetPosition(1);
		}

		//set a new pos
		public void SetPosition(int NewPosition)
		{
			Position = NewPosition;
		}

		//get the pos
		public int GetPosition()
		{
			return Position;
		}

		//move to next num
		public int NextPrime()
		{
			bool isPrime;

			// looping on all the numbers till the limit.
			for (int i = Position+1; i <= int.MaxValue; i++)
			{

				// the number is prime till proved otherwise.
				isPrime = true;

				// looping on all the candidates do divide i with no remainder.
				for (int j = 2; j <= Math.Sqrt(i); j++)
				{
					if (i % j == 0)
					{
						isPrime = false;
					}
				}

				if (isPrime)
				{
					SetPosition(i);
					return i;
				}
			}
			return int.MaxValue;
		}
	}
}
