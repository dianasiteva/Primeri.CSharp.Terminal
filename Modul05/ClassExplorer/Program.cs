using System;

namespace ClassExplorer
{

	public class person
	{
		public string sipleString = "тестова променлива от клас";

		public person ()
		{
			sipleString = "Промяна на тестовата променлива от клас.";
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на клас
			person _person = new person ();

			//Достъпване на клас
			Console.WriteLine ( _person.sipleString );
		}
	}
}
