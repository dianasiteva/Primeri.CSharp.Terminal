using System;
using System.Collections.Generic;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string _userinput = "";
			//List
			List<int> _list = new List<int>();
			_list.Add (5);
			_list.Add (3);
			_list.Add (9);

			//Потребителски код
			do {
				Console.WriteLine("? ");
				_userinput = Console.ReadLine();

					//Добавяне на стойности
				if ( _userinput.ToLower().Contains("add") )
				{
					try{
					int _add = 0;
						if ( int.TryParse  (_userinput.Split(' ')[1] , out _add))
						{
							_list.Add (_add);
						}
					}catch{}
					Console.WriteLine();
				}


					//Преглед на List
				if (_userinput.ToLower().Contains ("show"))
				{
					Console.Write ("_list: ");
					for (int i=0; i<_list.Count; i++)
					{
						Console.Write( _list[i] );
						if ( i!=_list.Count-1 ) Console.Write(", ");
					}
					Console.WriteLine("\n");
				}


					//Размер на List
				if (_userinput.ToLower().Contains ("size"))
				{
					Console.WriteLine("Размер на списъка: " + _list.Count.ToString() + "\n");
				}



			}
			while(_userinput != "exit" );


			//Задача
//			List<string> z = new List<string> ();
//			z.Add("Иван");
//			z.Add("Драган");
//			Console.WriteLine( z.Count );
//			if (z.Contains("Драган")) Console.WriteLine("Драган е тук");

//			2
//			Action<string> cw = Console.WriteLine;
//			List<string> z = new List<string> ();
//
//			z.Add("ябълка");
//			z.Add("круша");
//			z.Add("мармалад");
//			z.Add("грозде");
//
//			int i = z.IndexOf("мармалад");
//			z.RemoveAt(i);
//			foreach(string x in z) {
//				cw(x);
//			}



//			Action<string> cw = Console.WriteLine;
//			List<string> z = new List<string> ();
//
//			z.Add("ементал");
//			z.Add("дръжка");
//			z.Add("вафла");
//			z.Add("грозде");
//			z.Add("боркан");
//			z.Add("амфибия");
//
//			z.Sort();
//			cw( string.Join(", ",z) );
//			z.Reverse();
//			cw( string.Join(", ",z) );
		}
	}
}
