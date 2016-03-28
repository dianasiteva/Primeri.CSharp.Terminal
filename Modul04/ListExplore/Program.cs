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

					//Преглед на List
				if (_userinput.Contains ("show"))
				{
					Console.Write ("_list: ");
					for (int i=0; i<_list.Count; i++)
					{
						Console.Write( _list[i] );
						if ( i!=_list.Count-1 ) Console.Write(", ");
					}
				}Console.WriteLine();
					//Размер на List

			}
			while(_userinput != "exit" );
		}
	}
}
