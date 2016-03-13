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
			Console.WriteLine ("Резултатът a + b e " + (a + b).ToString() + ".\n");

			string test="1";
			test += ", 2";
			test += ", 33";
			test += ", 4";
			test += ", 5";

			Console.WriteLine ("Събиране с += : " + test + "\n");

			test = test.Replace (", ", ";");
			Console.WriteLine ("Работа с Replace: " + test + "\n");
			Console.WriteLine ("3ти знак : " + test.Split(';')[2] + "\n");

		}
	}
}
