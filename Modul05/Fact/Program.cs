using System;

namespace Fact
{
	class MainClass
	// 5! = 5 * 4 * 3 * 2 * 1    ; 0! = 1

	{

		public static int Fact ( int _fact )
		{
			if ( _fact <= 1 ) {
				return 1;
			}
			else{
				return _fact * Fact ( _fact - 1 );
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ( Fact ( 3 ) );
		}
	}
}
