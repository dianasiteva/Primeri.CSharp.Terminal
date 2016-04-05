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

				if ( usercommand.Contains ( "cmd05" )  )
				{
					Console.WriteLine ( "Брой четни числа : " + cmd05 ( usercommand ).Length.ToString()  );

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

		//Масиви
		public static string[] cmd05 ( string _input )
		{
			
			try
			{
				int _border = 0;
				string _temp = "";
				if ( int.TryParse ( _input.Split(' ')[1], out _border ) )
				{
					for ( int i=0;i<_border;i++ )
					{
						if ( i % 2 == 0 ) _temp += i.ToString();
						if ( i<_border-1 && i % 2 == 0 ) _temp += ",";


					}
					if ( _border % 2 == 0 ) _temp += _border.ToString();
					Console.WriteLine ( _temp );   //за проверка
					return ( _temp.Split (',') );
				}

			}catch{
			}

			return new string[1] { "0" };
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
//
//using System;
//using System.Collections.Generic;
//
//namespace TestovaPrograma {
//	class MainClass {
//		public static void Main (string[] args) {
//
//			// Изпълнете функцията тук       
//			int my = 0;
//			bool chetno;
//			chetno = proba(2,5, out my);
//			Console.WriteLine("Сумата на 2 и 5 е "+my+" и това е "+((chetno)?"четно":"нечетно"));
//		}
//		// Добавете новата функция тук
//		public static bool proba(int a, int b, out int c) {
//			c = a + b;
//			if (c%2 == 0) return true;
//			else return false;
//		}
//
//	}
//}
//using System;
//using System.Collections.Generic;
//
//namespace TestovaPrograma {
//	class MainClass {
//		public static void Main (string[] args) {
//			Action<string> cw = Console.WriteLine;
//			// Изпълнете функцията тук      
//			int x = 0;
//			proba (ref x);
//			cw("Променлива: "+x);
//			proba (ref x);
//			cw("Променлива: "+x);
//			proba (ref x);
//			cw("Променлива: "+x);
//
//		}
//		// Добавете новата функция тук
//		public static void proba(ref int a) {
//			a = a + 5;
//		}
//
//	}
//}
