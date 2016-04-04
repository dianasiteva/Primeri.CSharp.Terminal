using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main (string[] args)   
		{
			//Дефиниции
			string usercommand = "";


			//Потребителски команди
			do {
				Console.Write ("$ "); usercommand = Console.ReadLine();
				if ( usercommand.Contains ( "test" )  ) test ( usercommand );

			} while (usercommand != "exit");



		}
		//Действие
		public static void test ( string _input )           //test 5 -> 5*2
		{
			try{
					double _temp=0;
				if ( double.TryParse ( _input.Split (' ')[1], out _temp ) )
					{
						Console.WriteLine( "\nРезултатът от " + _temp.ToString() + "*2 e " + (_temp*_temp).ToString() );
					}

			}catch{ 
				}

		}


		//Да върне параметри




	}
}
