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
				if ( usercommand.Contains ( "cmd01" )  ) cmd01 ( usercommand );
				if ( usercommand.Contains ( "cmd02" )  ) Console.WriteLine ( cmd02 ( usercommand ));
				if ( usercommand.Contains ( "cmd03" )  )
				{
					double _a=0;
					if ( cmd03 ( usercommand , out _a ) )
					{
						Console.WriteLine ( "\na . a = " + _a.ToString() );
					}else{
						Console.WriteLine ( "\nКомандата не е въведена правилно." );
					}
				}
				if ( usercommand.Contains ( "cmd04" )  )
				{
					double _c=-2, _t=6;
					if ( cmd04 (ref _t) )
					{
						Console.WriteLine (_t );
					}
					if ( cmd04 (ref _c) )
					{
						Console.WriteLine ( 0 );
					}
				}
			} while (usercommand != "exit");



		}
		//Действие
		public static void cmd01 ( string _input )           //cmd01 5 -> 5*2
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
		public static int cmd02 ( string _input )               //cmd02
		{
			int _temp = 0;

				if ( int.TryParse ( _input.Split (' ')[1], out _temp ) )
				{
					_temp = _temp * _temp * _temp;

				}
				return _temp;


		}

		//Референции
		public static bool cmd03 ( string _input, out double _i )
		{

			try{
				string _p = _input.Split(' ')[1];
				double __p = 0;
				if ( double.TryParse( _p, out __p) )
				{
					_i = __p*__p;
					return true;
				}

			}catch{
			}

			_i = 0;
			return false;
		}


		public static bool cmd04 ( ref double _i )
		{
			double _temp = _i;
			_i = _i * _i;
			return ( _temp > 0 );

		}

	}
}
//using System;
//using System.Collections.Generic;
//
//namespace TestovaPrograma {
//	class MainClass {
//		public static void Main (string[] args) {
//
//			// Изпълнете функцията тук           
//			test("Моето съобщение");
//		}
//		// Добавете новата функция тук
//		public static void test( string msg ) {
//			Console.WriteLine( msg );
//		}
//	}
//}

//using System;
//using System.Collections.Generic;
//
//namespace TestovaPrograma {
//	class MainClass {
//		public static void Main (string[] args) {
//
//			// Изпълнете функцията тук           
//			int proba = suma( 5, 11); Console.WriteLine(proba);
//		}
//		// Добавете новата функция тук
//		public static int suma( int a, int b) {
//			return a + b;
//		}
//	}
//}