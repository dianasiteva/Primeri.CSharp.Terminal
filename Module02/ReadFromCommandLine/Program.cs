using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на параметри
			Console.Write ("Въведете b: ");
			b = Convert.ToInt32 ( Console.ReadLine ());


			//Печат на резултата
			Console.WriteLine ("Резултатът a + b e " + (a + b).ToString() + ".\n\n\n");
		}
	}
}
